using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using oop_sdk;
using oop_sdk.net;
using WebSocketSharp;

namespace oop_client
{
    public partial class MainForm : Form
    {
        private bool _connected;
        private bool _simulated;

        private WebSocket _ws;

        private List<Entity> _entityList;

        public MainForm()
        {
            InitializeComponent();
            Log("OOP CLIENT WELCOME");
            BStop.Enabled = false;
            BStart.Enabled = false;
            _connected = false;
            _simulated = false;
        }


        private void Log(string text)
        {
            TLog.Text += text + Environment.NewLine;
        }

        private void emulationSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EmulationSettingsForm().ShowDialog();
        }

        private void serverSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ServerSettingsForm().ShowDialog();
        }

        private void BConnectDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (Globals.Settings.Data.engine_settings == null)
                    throw new Exception("Сначала настройте параметры симуляции!");

                if (!_connected)
                {
                    _ws = new WebSocket($"ws://{Globals.Settings.Data.connection_string}/engine");
                    _ws.OnOpen += WsOnOnOpen;
                    _ws.OnMessage += WsOnOnMessage;
                    _ws.OnError += WsOnOnError;
                    _ws.OnClose += WsOnOnClose;
                    _ws.Connect();


                    BaseRequest<SetupSettings> setup = new BaseRequest<SetupSettings>
                    {
                        data = new SetupSettings
                        {
                            entity = Globals.Settings.Data.entity_settings,
                            engine = Globals.Settings.Data.engine_settings
                        },
                        method = RequestMethods.RequestSendSettings
                    };
                    _ws.Send(JsonConvert.SerializeObject(setup));
                }
                else
                {
                    if(_simulated)
                        throw new Exception("Для начала подключитесь к серверу!");

                    _ws.Close();
                    _ws = null;
                }

                _connected = !_connected;
                BConnectDisconnect.Text = !_connected ? "Подключиться к серверу" : "Отключиться от сервера";
                BStart.Enabled = _connected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WsOnOnClose(object sender, CloseEventArgs e)
        {
            _entityList?.Clear();
            _entityList = null;
            _connected = false;
            BConnectDisconnect.Text = !_connected ? "Подключиться к серверу" : "Отключиться от сервера";
            BStart.Enabled = _connected;
            BStop.Enabled = false;
            _simulated = false;
            Log("Отключен от сервера!");
            emulationSettingsToolStripMenuItem.Enabled = true;
            Text = "OOP Client";
            MessageBox.Show("Отключено от сервера!");
        }

        private void WsOnOnError(object sender, ErrorEventArgs e)
        {
            MessageBox.Show(e.Message, "Websocket error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void WsOnOnMessage(object sender, MessageEventArgs e)
        {
            try
            {
                BaseResponse<object> response = JsonConvert.DeserializeObject<BaseResponse<object>>(e.Data);

                if (response.error == 1)
                {
                    Log($"Ошибка от сервера: {response.message}");
                    throw new Exception(response.message);
                }

                if (response.method == RequestMethods.RequestSendSettings)
                {

                    _entityList = (response.data as JArray)?.ToObject<List<Entity>>();
                    Invoke((MethodInvoker) (() =>
                    {
                        UpdateList();
                        emulationSettingsToolStripMenuItem.Enabled = false;
                    }));
                    goto end;
                }

                if (response.method == RequestMethods.EmulationEventNewDay)
                {
                    Invoke((MethodInvoker)(() =>
                    {
                        TTotalDays.Text = $"Всего дней: {response.data}";
                    }));
                    goto end;
                }

                if (response.method == RequestMethods.EmulationEventHourTick)
                {
                    Invoke((MethodInvoker)(() =>
                    {
                        TCurrentHour.Text = $"Текущий час: {response.data}";
                    }));
                    goto end;
                }

                if (response.method == RequestMethods.RequestStartEmulation)
                {
                    Invoke((MethodInvoker)(() =>
                    {
                        TGlobalStatus.Text = "Статус: В работе";
                        BStart.Enabled = false;
                        BStop.Enabled = true;
                    }));
                    goto end;
                }

                if (response.method == RequestMethods.RequestStopEmulation)
                {
                    Invoke((MethodInvoker)(() =>
                    {
                        TGlobalStatus.Text = "Статус: Остановлен";
                        BStart.Enabled = true;
                        BStop.Enabled = false;
                    }));

                    goto end;
                }

                if (response.method == RequestMethods.EmulationEntityEvent)
                {
                    if (response.data is JObject jData)
                    {
                        Dictionary<string, int> data = jData.ToObject<Dictionary<string, int>>();
                        Invoke((MethodInvoker)(() =>
                        {
                            LEntityView.Items[data["id"]].SubItems[1].Text = GetStatus((EntityStatus)data["status"]);
                            Log($"Смена статуса оборудования [{data["id"]}]: {GetStatus((EntityStatus)data["status"])}");
                        }));
                    }
                }

                if (response.method == RequestMethods.EmulationStatus)
                {
                    if (response.data is bool status)
                    {
                        if (status)
                        {
                            Invoke((MethodInvoker)(() =>
                            {
                                BStart.Enabled = false;
                                BStop.Enabled = true;
                                TGlobalStatus.Text = "Статус: В работе";
                            }));
                        }
                        else
                        {
                            Invoke((MethodInvoker)(() =>
                            {
                                BStart.Enabled = true;
                                BStop.Enabled = false;
                                TGlobalStatus.Text = "Статус: Остановлен";
                            }));
                        }
                    }
                }
                
                end: ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WS ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateList()
        {
            LEntityView.Items.Clear();
            foreach (Entity e in _entityList)
            {
                ListViewItem lvi = new ListViewItem(e.Id.ToString());
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem() {Text = GetStatus(e.Status)});
                LEntityView.Items.Add(lvi);
            }
        }

        private string GetStatus(EntityStatus status)
        {
            switch (status)
            {
                case EntityStatus.EntityInRepairing:
                    return "В ремонте";

                case EntityStatus.EntityBroken:
                    return "Сломано";

                case EntityStatus.EntityFixed:
                    return "Нормально работает";

                default:
                    return "UNKNOWN";
            }
        }

        private void WsOnOnOpen(object sender, EventArgs e)
        {
            Log("Подключение успешно");
            Text = $"OOP Client :: {_ws.Url}";
        }

        private void BStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (Globals.Settings.Data.engine_settings == null)
                    throw new Exception("Для начала задайте настройки ТУ и предприятия");

                if(!_connected)
                    throw new Exception("Для начала подключитесь к серверу");


                BaseRequest<object> request = new BaseRequest<object>
                {
                    method = RequestMethods.RequestStartEmulation
                };
                _ws.Send(JsonConvert.SerializeObject(request));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "START ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BStrop_Click(object sender, EventArgs e)
        {
            try
            {
                if (Globals.Settings.Data.entity_settings == null)
                    throw new Exception("Для начала задайте настройки ТУ и предприятия");

                if (!_connected)
                    throw new Exception("Для начала подключитесь к серверу");


                BaseRequest<object> request = new BaseRequest<object>
                {
                    method = RequestMethods.RequestStopEmulation
                };
                _ws.Send(JsonConvert.SerializeObject(request));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "START ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

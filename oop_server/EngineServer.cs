using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using oop_sdk;
using oop_sdk.net;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace oop_server
{
    public class EngineServer : WebSocketBehavior
    {
        private Engine _engine;
        private bool _disconnected;

        protected override void OnMessage(MessageEventArgs e)
        {
            try
            {
                BaseRequest<object> request = JsonConvert.DeserializeObject<BaseRequest<object>>(e.Data);
                BaseResponse<object> response = new BaseResponse<object>
                {
                    method =  request.method,
                    error = 0,
                    message = ""
                };
                if (request.method == RequestMethods.RequestSendSettings)
                {
                    if (_engine != null)
                    {
                        response.error = 1;
                        response.message = "Engine already configured!";
                        goto send_rsp;
                    }

                    SetupSettings setup = ((request.data) as JObject)?.ToObject<SetupSettings>();
                    _engine = new Engine(setup?.engine, setup?.entity);
                    _engine.OnEntityChanged += EngineOnOnEntityChanged;
                    _engine.OnStatusChanged += EngineOnOnStatusChanged;
                    _engine.OnHourTick += EngineOnOnHourTick;
                    _engine.OnNewDay += EngineOnOnNewDay;

                    response.data = _engine.GetEntities();
                    goto send_rsp;
                }

                if (_engine == null)
                {
                    response.error = 1;
                    response.message = "Engine not configured!";
                    goto send_rsp;
                }

                if (request.method == RequestMethods.RequestStartEmulation)
                {
                    if (_engine.EngineStatus)
                    {
                        response.error = 1;
                        response.message = "Engine already started!";
                        goto send_rsp;
                    }
                    _engine.Start();
                }

                if (request.method == RequestMethods.RequestStopEmulation)
                {
                    if (!_engine.EngineStatus)
                    {
                        response.error = 1;
                        response.message = "Engine not started!";
                        goto send_rsp;
                    }
                    _engine.Stop();
                } 
                
                send_rsp: 

                Send(JsonConvert.SerializeObject(response));

            }
            catch (Exception ex)
            {
                ConsoleTools.DisplayError(ex.Message);
            }
        }

        private void EngineOnOnNewDay(int totaldays)
        {
            if (_disconnected)
                return;

            BaseResponse<object> response = new BaseResponse<object>
            {
                method = RequestMethods.EmulationEventNewDay,
                error = 0,
                message = "",
                data = _engine.TotalDays
            };
            Send(JsonConvert.SerializeObject(response));
        }

        private void EngineOnOnHourTick(int currenthour)
        {
            if(_disconnected)
                return;

            BaseResponse<object> response = new BaseResponse<object>
            {
                method = RequestMethods.EmulationEventHourTick,
                error = 0,
                message = "",
                data = _engine.CurrentHour
            };
            Send(JsonConvert.SerializeObject(response));
        }

        private void EngineOnOnStatusChanged(bool enginestatus)
        {
            if (_disconnected)
                return;

            BaseResponse<object> response = new BaseResponse<object>
            {
                method = RequestMethods.EmulationStatus,
                error = 0,
                message = "",
                data = _engine.EngineStatus
            };
            Send(JsonConvert.SerializeObject(response));
        }

        private void EngineOnOnEntityChanged(int entityid, EntityStatus status)
        {
            if (_disconnected)
                return;

            BaseResponse<object> response = new BaseResponse<object>
            {
                method = RequestMethods.EmulationEntityEvent,
                error = 0,
                message = "",
                data = new Dictionary<string, int>
                {
                    {"id", entityid },
                    {"status", (int)status }
                }
            };
            Send(JsonConvert.SerializeObject(response));
        }

        protected override void OnOpen()
        {
            ConsoleTools.DisplayLog($"New connection: {ID}");
        }

        protected override void OnClose(CloseEventArgs e)
        {
            _disconnected = true;
            _engine.Stop();
            ConsoleTools.DisplayLog($"Connection closed: {ID}");
        }
    }
}
using System;
using System.Windows.Forms;

namespace oop_client
{
    public partial class ServerSettingsForm : Form
    {
        public ServerSettingsForm()
        {
            InitializeComponent();
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(TServer.Text))
                return;

            Globals.Settings.Data.connection_string = TServer.Text;
            Globals.Settings.Save();
            Close();
        }

        private void ServerSettingsForm_Load(object sender, EventArgs e)
        {
            if(Globals.Settings.Data.connection_string == null)
                return;

            TServer.Text = Globals.Settings.Data.connection_string;
        }
    }
}

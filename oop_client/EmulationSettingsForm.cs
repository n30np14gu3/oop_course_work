using System;
using System.Windows.Forms;
using oop_sdk;

namespace oop_client
{
    public partial class EmulationSettingsForm : Form
    {
        public EmulationSettingsForm()
        {
            InitializeComponent();
        }

        private void EmulationSettingsForm_Load(object sender, EventArgs e)
        {
            if (Globals.Settings.Data.engine_settings == null)
            {
                Globals.Settings.Data.engine_settings = new EngineSettings
                {
                    HourTime = 500,
                    L = 1,
                    M = 1,
                    N = 1
                };

                Globals.Settings.Data.entity_settings = new EntitySettings
                {
                    R = 1,
                    Z = 1
                };
            }

            NLineCapacity.Value = Globals.Settings.Data.engine_settings.L;
            NLinesCount.Value = Globals.Settings.Data.engine_settings.M;
            NEntityCount.Value = Globals.Settings.Data.engine_settings.N;

            NFailsCount.Value = Globals.Settings.Data.entity_settings.Z;
            NMathWait.Value = Globals.Settings.Data.entity_settings.R;

            NHourTime.Value = Globals.Settings.Data.engine_settings.HourTime;
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            Globals.Settings.Data.engine_settings.L = (int)NLineCapacity.Value;
            Globals.Settings.Data.engine_settings.M = (int)NLinesCount.Value; 
            Globals.Settings.Data.engine_settings.N = (int)NEntityCount.Value;

            Globals.Settings.Data.entity_settings.Z = (int)NFailsCount.Value;
            Globals.Settings.Data.entity_settings.R = (int)NMathWait.Value;

            Globals.Settings.Data.engine_settings.HourTime = (int)NHourTime.Value;
            Globals.Settings.Save();
            Close();
        }
    }
}

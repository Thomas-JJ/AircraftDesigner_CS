using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aircraftCreator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Aircraft aircraft = new Aircraft();
        string errorMessage = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            //add aircraft type selections
            string[] acTypes = new string[] {"General Aviation - Single Prop","General Aviation - Twin Prop"};
            for(int i = 0; i < acTypes.Length; i++)
            {
                cb_ACtype.Items.Add(acTypes[i]);
            }

            //add mission profile selections
            string[] missionProfiles = new string[] { "Takeoff-Climb-Cruise-Loiter-Land"};
            for (int i = 0; i < missionProfiles.Length; i++)
            {
                cb_MissionProfile.Items.Add(missionProfiles[i]);
            }

            //add engine selections
            string[] engines = new string[] { "Piston-Prop (Fixed Pitch)" , "Piston-Prop (Variable Pitch)" , "Turboprop" };
            for (int i = 0; i < engines.Length; i++)
            {
                cb_EngineType.Items.Add(engines[i]);
            }

            //add Wing Configuration selections
            string[] wings = new string[] { "Conventional", "Delta" };
            for (int i = 0; i < wings.Length; i++)
            {
                cb_WingConfig.Items.Add(wings[i]);
            }

            //add Landing Gear Configuration selections
            string[] lgConfig = new string[] { "Retractable", "Non-retractable" };
            for (int i = 0; i < lgConfig.Length; i++)
            {
                cb_LandingGearConfig.Items.Add(lgConfig[i]);
            }

            setDefaultValues();
        }
        private void btn_Calc_Click(object sender, EventArgs e)
        {
            errorMessage = "";
            bool inputsValid = inputValidations();
            bool inputsInBounds;
            if (inputsValid)
            {
                inputsInBounds = inputsOutOfBounds();
                if (inputsInBounds)
                {
                    string acType = cb_ACtype.SelectedIndex.ToString();
                    string payload = tb_PayloadWeight.Text;
                    string velocity = tb_CruiseSpeed.Text;
                    string range = tb_Range.Text;
                    string engineType = cb_EngineType.SelectedIndex.ToString();
                    string wingspan = tb_WingSpan.Text;
                    string wingConfig = cb_WingConfig.SelectedIndex.ToString();
                    string sweep = tb_SweepAngle.Text;
                    string cord = tb_RootCordLength.Text;
                    string landinggear = cb_LandingGearConfig.SelectedIndex.ToString();
                    string mission = cb_MissionProfile.SelectedIndex.ToString();

                    aircraft.setACconfig(acType, payload, velocity, range, engineType, wingspan, wingConfig, sweep, cord, landinggear, mission);

                    //Perform Calculation for Initial sizing using class method
                    double initialWeight = aircraft.setInitialWeight();
                    lbl_OutputInitialWeight.Text = Math.Round(initialWeight,2).ToString();
                }
                else
                {
                    MessageBox.Show(errorMessage,"ERROR: Inputs Out of Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show(errorMessage, "ERROR: Invalid Inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool inputValidations()
        {
            bool valid = true;
            // Text box input validations
            string[,] tbInputs = new string[,] { 
                { tb_CruiseSpeed.Text, "Cruise Speed" }, 
                { tb_Range.Text, "Range"}, 
                { tb_WingSpan.Text, "Wingspan"}, 
                { tb_PayloadWeight.Text, "Payload" }, 
                { tb_RootCordLength.Text, "Root Cord Length" } 
            };
            for(int i = 0; i < tbInputs.GetLength(0); i++)
            {
                if (tbInputs[i,0] != "")
                {
                    if (!Double.TryParse(tbInputs[i,0], out double val))
                    {
                        errorMessage = errorMessage + "Invalid Input: " + tbInputs[i,1];
                        valid = false;
                    }
                }
                else
                {
                    errorMessage = errorMessage + "\n You must enter a " + tbInputs[i,1];
                    valid = false;
                }
            }

            // Sweep Angle Validations
            if (tb_SweepAngle.Text != "")
            {
                if (cb_WingConfig.SelectedIndex == 0 && tb_SweepAngle.Text !="0")
                {
                    errorMessage = errorMessage + "\n Conventional Wing Configurations cannot have a Sweep Angle";
                    valid = false;
                }
                else
                {
                    if (!Double.TryParse(tb_SweepAngle.Text, out double val5))
                    {
                        errorMessage = errorMessage + "\n Invalid Sweep Angle Input";
                        valid = false;
                    }
                }
            }
            else
            {
                tb_SweepAngle.Text = "0";
            }

            // Combo box input validations
            int[] cbInputs = new int[] { cb_ACtype.SelectedIndex, cb_MissionProfile.SelectedIndex, cb_EngineType.SelectedIndex, cb_WingConfig.SelectedIndex, cb_LandingGearConfig.SelectedIndex };
            List<string> cbInputError = new List<string> { "Aircraft Type", "Mission Profile", "Engine Type", "Wing Configuration", "Landing Gear Configuration"};
            for(int i = 0; i < cbInputs.Length; i++)
            {
                if(cbInputs[i] == -1)
                {
                    errorMessage = errorMessage + "\n You must select a " + cbInputError[i];
                    valid = false;
                }
            }

            return valid;
        }
        public bool inputsOutOfBounds()
        {
            bool valid = true;
            // numerical inputs can't be negative;
            // Text box input validations
            double inputValue;
            double upperLimit;
            double lowerLimit;
            string[,] tbInputs = new string[,] 
                { 
                    { tb_CruiseSpeed.Text, "Cruise Speed", "20", "120" }, 
                    { tb_Range.Text, "Range","50000","2000000" }, 
                    { tb_WingSpan.Text, "Wingspan", "5","15" }, 
                    { tb_PayloadWeight.Text, "Payload", "0", "1200" }, 
                    { tb_RootCordLength.Text, "Root Cord Length","1.2","3" },
                    { tb_SweepAngle.Text, "Sweep Angle","0","60" }
                };
            for (int i = 0; i < tbInputs.GetLength(0); i++)
            {
                inputValue = Double.Parse(tbInputs[i, 0]);
                lowerLimit = Double.Parse(tbInputs[i, 2]);
                upperLimit = Double.Parse(tbInputs[i, 3]);
                if (inputValue < lowerLimit || inputValue > upperLimit)
                {
                        errorMessage = errorMessage + "\n" + tbInputs[i, 1] + " Must be between " + tbInputs[i,2] + " and " + tbInputs[i,3];
                        valid = false;
                }
            }
            return valid;
        }
        public void setDefaultValues()
        {             
            //Set initial values
            cb_ACtype.SelectedIndex = 0;
            cb_MissionProfile.SelectedIndex = 0;
            tb_PayloadWeight.Text = "100";
            tb_Range.Text = "1200000";
            tb_CruiseSpeed.Text = "70";
            cb_EngineType.SelectedIndex = 0;
            tb_WingSpan.Text = "10";
            cb_WingConfig.SelectedIndex = 0;
            tb_RootCordLength.Text = "2";
            tb_SweepAngle.Text = "0";
            cb_LandingGearConfig.SelectedIndex = 0;
        }
        private void btn_resetValues_Click(object sender, EventArgs e)
        {
            setDefaultValues();
        }
        private string[] getAirCraftConfigInputs()
        {
            string acType = cb_ACtype.SelectedIndex.ToString();
            string payload = tb_PayloadWeight.Text;
            string velocity = tb_CruiseSpeed.Text;
            string range = tb_Range.Text;
            string engineType = cb_EngineType.SelectedIndex.ToString();
            string wingspan = tb_WingSpan.Text;
            string wingConfig = cb_WingConfig.SelectedIndex.ToString();
            string sweep = tb_SweepAngle.Text;
            string cord = tb_RootCordLength.Text;
            string landinggear = cb_LandingGearConfig.SelectedIndex.ToString();
            string mission = cb_MissionProfile.SelectedIndex.ToString();

            string[] configuration = new string[] { acType, payload, velocity, range, engineType, wingspan, wingConfig, sweep, cord, landinggear, mission };
            
            return configuration;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveConfiguration(aircraft.getACconfigName(),false);
        }
        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            SaveConfiguration("",true);
        }

        private void SaveConfiguration(string Name, bool newConfig)
        {
            errorMessage = "";
            bool inputsValid = inputValidations();
            bool inputsInBounds;
            string name = Name;
            bool failSave;
            SaveAsForm saveAsForm = new SaveAsForm();

            if (inputsValid)
            {
                inputsInBounds = inputsOutOfBounds();
                if (inputsInBounds)
                {
                    while (name == "" || name == null)
                    {
                        newConfig = true;
                        saveAsForm.StartPosition = FormStartPosition.CenterScreen;
                        saveAsForm.ShowDialog();
                        name = saveAsForm.name;
                        aircraft.setACconfigName(name);
                    }
                    string acType = cb_ACtype.SelectedIndex.ToString();
                    string payload = tb_PayloadWeight.Text;
                    string velocity = tb_CruiseSpeed.Text;
                    string range = tb_Range.Text;
                    string engineType = cb_EngineType.SelectedIndex.ToString();
                    string wingspan = tb_WingSpan.Text;
                    string wingConfig = cb_WingConfig.SelectedIndex.ToString();
                    string sweep = tb_SweepAngle.Text;
                    string cord = tb_RootCordLength.Text;
                    string landinggear = cb_LandingGearConfig.SelectedIndex.ToString();
                    string mission = cb_MissionProfile.SelectedIndex.ToString();

                    aircraft.setACconfig(acType, payload, velocity, range, engineType, wingspan, wingConfig, sweep, cord, landinggear, mission);

                    string[] configuration = new string[12] { name, acType, payload, velocity, range, engineType, wingspan, wingConfig, sweep, cord, landinggear, mission };
                    SQL sql = new SQL();
                    if (newConfig)
                    {
                        failSave = sql.InsertAircraft(configuration);
                    }
                    else
                    {
                        failSave = sql.UpdateAircraft(configuration);
                    }
                    if (failSave)
                    {
                        MessageBox.Show("Configuration Saved Successfully","Save Success");
                    }
                    else
                    {
                        MessageBox.Show("Your Configuration Could Not Be Save At This Time \n \n Please Try Again And Contact Support If This Issue Occurs Again.","ERROR: Configuration could not be saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(errorMessage, "ERROR: Inputs Out of Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(errorMessage, "ERROR: Invalid Inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void setUIvalues(string acType, string payload, string velocity, string range, string engineType, string wingspan, string wingConfig, string sweep, string cord, string landinggear, string mission)
        {
            cb_ACtype.SelectedIndex = Int32.Parse(acType);
            cb_MissionProfile.SelectedIndex = Int32.Parse(mission);
            tb_PayloadWeight.Text = payload;
            tb_Range.Text = range;
            tb_CruiseSpeed.Text = velocity;
            cb_EngineType.SelectedIndex = Int32.Parse(engineType);
            tb_WingSpan.Text = wingspan;
            cb_WingConfig.SelectedIndex = Int32.Parse(wingConfig);
            tb_RootCordLength.Text = cord;
            tb_SweepAngle.Text = sweep;
            cb_LandingGearConfig.SelectedIndex = Int32.Parse(landinggear);
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadACForm loadACForm = new LoadACForm();
            loadACForm.StartPosition = FormStartPosition.CenterScreen;
            string Name = "";
            while (Name == "" || Name == null)
            {
                loadACForm.ShowDialog();
                Name = loadACForm.ac_name;
                aircraft.setACconfigName(loadACForm.ac_name);
                lb_acName.Text = aircraft.getACconfigName();
            }
            SQL sql = new SQL();

            DataTable configuration = sql.getConfiguration(loadACForm.ac_id);

            string acType = configuration.Rows[0][0].ToString();
            string payload = configuration.Rows[0][1].ToString();
            string velocity = configuration.Rows[0][2].ToString();
            string range = configuration.Rows[0][3].ToString();
            string engineType = configuration.Rows[0][4].ToString();
            string wingspan = configuration.Rows[0][5].ToString();
            string wingConfig = configuration.Rows[0][6].ToString();
            string sweep = configuration.Rows[0][7].ToString();
            string cord = configuration.Rows[0][8].ToString();
            string landinggear = configuration.Rows[0][9].ToString();
            string mission = configuration.Rows[0][10].ToString();

            aircraft.setACconfig(acType, payload, velocity, range, engineType, wingspan, wingConfig, sweep, cord, landinggear, mission);

            setUIvalues(acType, payload, velocity, range, engineType, wingspan, wingConfig, sweep, cord, landinggear, mission);

        }
    }
}

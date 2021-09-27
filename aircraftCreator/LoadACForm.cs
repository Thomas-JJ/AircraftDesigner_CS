using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace aircraftCreator
{
    public partial class LoadACForm : Form
    {
        AircraftName[] allAircraftNames;
        public string ac_name { get; set; }
        public int ac_id { get; set; }

        private bool enterPressed = false;

        // Handle the KeyDown event to determine the type of character entered into the control.
        private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            enterPressed = false;
            // Determine whether the keystroke is a number from the top of the keyboard.
            if (e.KeyCode == Keys.Return)
            {
                enterPressed = true;
                string selectedAC = lb_AircraftNames.SelectedItem.ToString();
                foreach (AircraftName ac in allAircraftNames)
                {
                    if (ac.ac_Name == selectedAC)
                    {
                        ac_name = selectedAC;
                        ac_id = ac.ac_id;
                    }
                }
                this.Close();
            }
        }

        // This event occurs after the KeyDown event and can be used to prevent
        // characters from entering the control.
        private void textBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (enterPressed == true)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }



        public LoadACForm()
        {
            InitializeComponent();

        }

        private void LoadACForm_Load(object sender, EventArgs e)
        {
            SQL sql = new SQL();
            lb_AircraftNames.Items.Clear();
            allAircraftNames = sql.GetList(1);

            foreach (AircraftName ac in allAircraftNames)
            {
                lb_AircraftNames.Items.Add(ac.ac_Name);
            }
        }

        private void btn_LoadACConfig_Click(object sender, EventArgs e)
        {
            string selectedAC = lb_AircraftNames.SelectedItem.ToString();
            foreach (AircraftName ac in allAircraftNames)
            {
                if(ac.ac_Name == selectedAC)
                {
                    ac_name = selectedAC;
                    ac_id = ac.ac_id;
                }
            }
            this.Close();

        }
    }
}

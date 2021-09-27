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
    public partial class SaveAsForm : Form
    {
        public string name;
        public SaveAsForm()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            name = tb_AircraftName.Text;           
            this.Close();
        }

        private void SaveAsForm_Load(object sender, EventArgs e)
        {
            name = "";
        }
    }
}

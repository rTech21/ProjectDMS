using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDMS
{
    public partial class FormStartMenu : Form
    {
        FormMasterForm MasterForm;
        FormMainMenu MainMenu;

        public FormStartMenu(FormMasterForm mf, FormMainMenu fr)
        {
            InitializeComponent();
            MasterForm = mf;
            MainMenu = fr;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu.Show();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //hide this form 
            this.Hide();
            
            //check if player wants to be DM or not
            if (checkBoxDM.Checked)
                MasterForm.playerDMDecision(0);            
            else
                MasterForm.playerDMDecision(1);            

            //show master form
            MasterForm.Show();
        }
    }
}

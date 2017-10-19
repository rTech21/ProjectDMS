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
    public partial class FormMasterForm : Form
    {
        FormMainMenu MainMenuForm;

        public FormMasterForm()
        {
            InitializeComponent();
            //Create an instance of the main menu form
            MainMenuForm = new FormMainMenu(this);
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {                    
            //Show main Menu
            MainMenuForm.Show();
        }

        private void closeAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }        

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hide the master form
            this.Hide();
            //show the main menu
            MainMenuForm.Show();
        }

        //determines if the player should see the DM or player interface
        public void playerDMDecision(int DM)
        {
            switch (DM)
            {
                case 0:
                    groupBoxDM.Show();
                    groupBoxPlayer.Hide();
                    break;
                case 1:
                    groupBoxDM.Hide();
                    groupBoxPlayer.Show();
                    break;
            }
        }
    }
}

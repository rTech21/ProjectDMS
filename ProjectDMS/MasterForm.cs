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
        //variables
        FormMainMenu MainMenuForm;
        //string to hold the DM's username
        string DMName;
        //Creates an array to store the player names
        string[] PlayerNames = new string[8];

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

        //sets up either the player or DM interface depending on the player's selection in the start menu
        public void playerDMDecision(int DM, string name)
        {
            switch (DM)
            {
                case 0:
                    groupBoxDM.Show();
                    groupBoxPlayer.Hide();
                    DMName = name;
                    break;
                case 1:
                    groupBoxDM.Hide();
                    groupBoxPlayer.Show();
                    dungeonMasterToolStripMenuItem.Visible = false;
                    PlayerNames[0] = name;
                    break;
            }
            //changes the text of the userName tool tip to the user's username
            userNameToolStripMenuItem.Text = name;

        }
    }
}

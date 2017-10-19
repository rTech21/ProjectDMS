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

        private void FormStartMenu_Load(object sender, EventArgs e)
        {
            textBoxPlayerName.Focus();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu.Show();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {                     
            try
            {
                Exception nullEntry = new Exception();

                //get the player's chosen username
                string name = textBoxPlayerName.Text;

                if (name == "")
                {
                    MessageBox.Show("User name cannot be blank", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //Clears the player name text box
                    textBoxPlayerName.Clear();
                    //Sets the focus to the player name text box
                    textBoxPlayerName.Focus();
                }
                else
                {
                    //check if player wants to be DM or not
                    if (checkBoxDM.Checked)
                        MasterForm.playerDMDecision(0, name);
                    else
                        MasterForm.playerDMDecision(1, name);

                    //Clears the player name text box
                    textBoxPlayerName.Clear();

                    //hide this form
                    this.Hide();

                    //show master form
                    MasterForm.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Unhandled Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

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
    public partial class FormMainMenu : Form
    {

        FormMasterForm MasterForm;
        FormStartMenu StartMenu;

        public FormMainMenu(FormMasterForm mf)
        {
            InitializeComponent();
            MasterForm = mf;

            //Create an instance of the start menu form
            StartMenu = new FormStartMenu(MasterForm, this);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartMenu.Show();            
        }

    }
}

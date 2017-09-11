﻿using System;
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
        FormStartMenu startMenu = new FormStartMenu();

        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            startMenu.Show();
            this.Enabled = false;
        }
    }
}

﻿using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace BugigangaDigitalSecurity
{
    public partial class F_Principal : Form
    {
        public F_Principal()
        {
            InitializeComponent();
        }

        private void btn_welcome_Click(object sender, EventArgs e)
        {
            F_Menu f_Menu = new F_Menu();
            f_Menu.ShowDialog();
            Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pb_principal_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("MicrosoftEdge", "https://www.linkedin.com/in/danhpaiva/");
            }
            catch (Exception)
            {
                MessageBox.Show("Contato: danpaiva@live.com");
            }
        }
    }
}

﻿namespace TrinketDigitalSecurity
{
    public partial class F_M_Four_01 : Form
    {
        public F_M_Four_01()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            F_M_Four_02 f_M_Four_02 = new F_M_Four_02();
            f_M_Four_02.ShowDialog();
            Close();
        }
    }
}

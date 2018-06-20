using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sports_Office_App
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are your sure you want to Exit the program?", "Confirm ", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Main_Form().ShowDialog();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @try
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Please fill mandatory fields");
            else if (txtPassword.Text != txtConfirm.Text)
                MessageBox.Show("Password do not match");
            else MessageBox.Show("Login Soccessful");
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string EmailOrPhone = txtEmail.Text;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string Password = txtPassword.Text;
        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {
            string cPassword = txtConfirm.Text;
        }
    }
}

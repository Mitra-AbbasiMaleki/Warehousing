using BaseBackend.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Warehousing
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cmbAccessLevel.SelectedIndex == 0)
            { 
                MessageBox.Show("لطفا سطح دسترسی را انتخاب کنید");
                return;
            }
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text)) return;
            if ((txtUserName.Text == "admin") && (txtPassword.Text == "admin"))
            {
                
                MainForm frmMain = new MainForm();
                frmMain.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Please Enter Valid Input");
                txtUserName.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }
        }


        private void FormLogin_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            lbltime.Text = DateTime.Now.ToShortTimeString();
            cmbAccessLevel.DataSource = Enum.GetValues(typeof(UserRole));
        }

    }
}

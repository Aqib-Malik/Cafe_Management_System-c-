using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    public partial class logIn : Form
    {
        public static string  user_name,current_user;
        functions fn = new functions();
        string query;
        public logIn()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            user_name = txt_username.Text;
            //MessageBox.Show(create_account.ra);
            query = "select * from signup where user_name='" + txt_username.Text.Trim() + "' and 	password='" + txt_password.Text.Trim() + "'";
            fn.checkData(query);
            if (functions.g == true)
            {
                current_user = txt_username.Text;
                //MessageBox.Show("successfully login");
                Dashboard a = new Dashboard();
                this.Hide();
                a.Show();
               

            }

            else
            {
                MessageBox.Show("Invalid Cradentials", "Invalid information");
             
            }
        }

        private void logIn_Load(object sender, EventArgs e)
        {
            txt_username.Text = signUp.name;
            txt_password.Text = signUp.pass;
        }

        private void guest_lnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard a = new Dashboard("Guest");
            a.Show();
            this.Hide();
        }
    }
}

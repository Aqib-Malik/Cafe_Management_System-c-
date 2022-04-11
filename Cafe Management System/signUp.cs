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
    public partial class signUp : Form
    {
        public static string name, pass;
        functions fn = new functions();
        string query;
        public static string ra;
        public signUp()
        {
            InitializeComponent();
        }

        private void guest_lnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            logIn a = new logIn();
            this.Hide();
            a.Show();
        }

        private void signUp_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard a = new Dashboard("Guest");
            a.Show();
            this.Hide();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            
            if ((txt_username.Text != "") && (txt_email.Text != "") && (txt_pass.Text != "") && (txt_phone.Text != ""))
            {
                query = "insert into signup(user_name,email,phone,password)values('" + txt_username.Text + "','" + txt_email.Text + "','" + Int64.Parse(txt_phone.Text) + "','" + txt_pass.Text + "')";
                name = txt_username.Text;
                pass = txt_pass.Text;
                fn.setData(query);
                logIn a = new logIn();
                this.Hide();
                a.Show();
                


            }
            else
            {
                MessageBox.Show("Incomplete Data", "Incomplete");
                
            }
        }
    }
}

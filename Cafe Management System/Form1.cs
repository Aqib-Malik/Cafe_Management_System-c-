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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard a = new Dashboard("Guest");
            a.Show();
            this.Hide();
            
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if(txt_username.Text=="aqib"&&txt_password.Text=="123")
            {
                Dashboard a = new Dashboard();
                
                a.Show();
                this.Hide();
            }
            else
            {
                //MessageBox.Show("Invalid Cradentials", "Invalid information");
                int t = ClassLibrary1.Class1.add(2, 4);
                MessageBox.Show(t.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

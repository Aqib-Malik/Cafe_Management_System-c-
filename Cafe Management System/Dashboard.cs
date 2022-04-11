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
    public partial class Dashboard : Form
    {
        functions fn = new functions();
        string query;
        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(string user)
        {
            InitializeComponent();////other code of thid constructor should b bellow this
            if (user == "Guest")
            {
                removeitem_btn.Hide();
                additem_btn.Hide();
                updateitem_btn.Hide();

            }
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (logIn.current_user != null)
            {
                lbl_user.Text = "User: " + logIn.current_user.ToUpper();
            }
            
            uc_additem1.Visible = false;
            uC_placerorder1.Visible = false;
            uC_Update_item1.Visible = false;
            uC_RemoveItem1.Visible = false;
        }

        private void logout_btn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            logIn.current_user = "";
            logIn b = new logIn();
            this.Hide();
            b.Show();
            
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void additem_btn_Click(object sender, EventArgs e)
        {
            uc_additem1.Visible = true;
            uc_additem1.BringToFront();
        }

        private void placeorder_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void placeorder_btn_Click_1(object sender, EventArgs e)
        {
            userControl11.SendToBack();
            guna2Transition1.ShowSync(uC_placerorder1);
            uC_placerorder1.Visible = true;
            uC_placerorder1.BringToFront();
        }

        private void updateitem_btn_Click(object sender, EventArgs e)
        {
            uC_Update_item1.Visible = true;
            uC_Update_item1.BringToFront();
           
            //uC_Update_item1.load_data();
        }

        private void removeitem_btn_Click(object sender, EventArgs e)
        {
            uC_RemoveItem1.Visible = true;
            uC_RemoveItem1.BringToFront();

        }
        public void load_data()
        {
            query = "select * from items";
            DataSet ds = fn.getData(query);
            
        }

        private void lbl_user_Click(object sender, EventArgs e)
        {

        }
    }
}

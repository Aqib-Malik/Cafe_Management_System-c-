using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System.All_User_Controls
{
    public partial class uc_additem : UserControl
    {
        
        functions fn = new functions();
        String query;
        //string connectionstring = "Server=localhost;Database=cafe_database;Uid=root;Pwd=''";//string constring = "Server=localhost;Database=mywork;Uid=root;Pwd=''";
        //int userid = 0;
        public uc_additem()
        {
            InitializeComponent();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_additem_Click(object sender, EventArgs e)
        {
            query = "insert into items(name,category,price)values('"+ txt_itemname.Text+ "','" + txt_category.Text + "','" + txt_price.Text + "')";
            fn.setData(query);
            clearall();
            
        }
        public void clearall()
        {
            txt_itemname.Text = "";
            txt_category.Text = "";
            txt_price.Text = "";
        }

        private void uc_additem_Leave(object sender, EventArgs e)
        {
            clearall();
        }

        private void txt_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uc_additem_Load(object sender, EventArgs e)
        {

        }
    }
}

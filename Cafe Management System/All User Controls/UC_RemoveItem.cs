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
    public partial class UC_RemoveItem : UserControl
    {
        functions fn = new functions();
        string query;
        public UC_RemoveItem()
        {
            InitializeComponent();
        }

        private void UC_RemoveItem_Load(object sender, EventArgs e)
        {
            loadData();
            Del_label.Text = "How to delete?";
            Del_label.ForeColor = Color.Blue;
            
        }
        public void loadData()
        {
            query = "select * from items";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where name like '" +txt_search.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        public void del_dataa(String x)
        {
            query = "delete from items where name='" + x + "'";

            fn.setData(query);
            loadData();
        }
        int id;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("Are you sure u want to delte this item?","Important message!",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                try
                {
                    String b = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    
                    del_dataa(b);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void Del_label_Click(object sender, EventArgs e)
        {
            Del_label.ForeColor = Color.Red;
            Del_label.Text = "*Click on row to delete the item.";
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}

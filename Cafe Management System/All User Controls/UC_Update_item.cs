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
    public partial class UC_Update_item : UserControl
    {
        
        functions fn = new functions();
        string query;
        public UC_Update_item()
        {
            InitializeComponent();
        }

        private void UC_Update_item_Load(object sender, EventArgs e)
        {
            load_data();
            query = "select * from items";
            load_data();

        }
        
        public void load_data()
        {
            query = "select * from items";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txt_searchitem_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where name like '" + txt_searchitem.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
            
        }
        
        
        
        public void load_dataa(String x)
        {
            query = "select * from items where name='" + x + "'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
            string q = ds.Tables[0].ToString();
           
        }
        int ad;
       
        
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             try
            {
                String b = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                ad=int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                load_dataa(b);

                string category = guna2DataGridView1.Rows[0].Cells[1].Value.ToString();
                string name = guna2DataGridView1.Rows[0].Cells[0].Value.ToString();
                int price = int.Parse(guna2DataGridView1.Rows[0].Cells[2].Value.ToString());
                nwa.Text = category;
                txt_updateName.Text = name;
                txt_updateprice.Text = price.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_updateName.Text != "")
            {
                query = "update items set name='" + txt_updateName.Text + "',category='" + nwa.Text + "',price=" + txt_updateprice.Text + "  where iid=" + ad + "";
                fn.setData(query);
                load_data();
                txt_updateName.Clear();
                txt_updateprice.Clear();
            }
            else
            {
                MessageBox.Show("Please choose atleast one item", "select");
            }
            
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_updatwcategory_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

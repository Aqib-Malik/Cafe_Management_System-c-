using DGVPrinterHelper;
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
    
    public partial class UC_placerorder : UserControl
    {
        functions fn = new functions();
        String query;
        public UC_placerorder()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            String category = comboCategory.Text;
            query = "select name from items where category='"+category+"'";
            show_list_item(query);

        }
       
        private void UC_placerorder_Load(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
          
            String category = comboCategory.Text;
            query = "select name from items where category='" + category + "' and name like '" + txt_search.Text + "%'";
            show_list_item(query);

        }
        void show_list_item(string query)
        {
            listBox1.Items.Clear();
            String category = comboCategory.Text;
            
            DataSet ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            TxtQuantity.ResetText();
            txt_totall.Clear();
            string text = listBox1.GetItemText(listBox1.SelectedItem);
            
            txt_itemname.Text = text;
            query= "select price from items where name ='" + text + "'";
            DataSet ds = fn.getData(query);
            try
            {
                txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch { }
        }

        private void TxtQuantity_ValueChanged(object sender, EventArgs e)
        {
            
            Int64 qua = Int64.Parse(TxtQuantity.Value.ToString());
            Int64 pri = Int64.Parse(txtPrice.Text.ToString());
            Int64 t = qua * pri;
            txt_totall.Text=t.ToString();
        }
        protected int n, totall = 0;

        private void label_totallAmount_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
            }
            catch { }
            totall = totall - amount;
            label_totallAmount.Text = "Rs "+totall;
        }
        
        int amount;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch { }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Cusomer Bill";
            printer.SubTitle = String.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Totall payable Amount :" + label_totallAmount.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(guna2DataGridView1);
            totall = 0;
            guna2DataGridView1.Rows.Clear();
            label_totallAmount.Text = "Rs. " + totall;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_addtocart_Click(object sender, EventArgs e)
        {
            
            if ((TxtQuantity.Value == 0) || (TxtQuantity.Value == 100)) 
            {
                MessageBox.Show("1:Please select the quantity.\n2:Quantity should b less than 100.", "Possible Error");
                //MessageBox.Show("Please select the quantity", "Quantity");
            }
            else
            {
                try
                {
                    if ((TxtQuantity.Value == 0))
                    {
                        MessageBox.Show("Please select the quantity", "Quantity");
                    }

                    else
                    {
                        n = guna2DataGridView1.Rows.Add();
                        guna2DataGridView1.Rows[n].Cells[0].Value = txt_itemname.Text;
                        guna2DataGridView1.Rows[n].Cells[1].Value = txtPrice.Text;
                        guna2DataGridView1.Rows[n].Cells[2].Value = TxtQuantity.Value;
                        guna2DataGridView1.Rows[n].Cells[3].Value = txt_totall.Text;
                        totall = totall + int.Parse(txt_totall.Text.ToString());
                        label_totallAmount.Text = "Rs. " + totall.ToString();
                    }
                    txt_search.Text = "";
                    TxtQuantity.Value = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //TxtQuantity.ResetText();
            }
        }
    }
}

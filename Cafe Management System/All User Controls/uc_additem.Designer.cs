
namespace Cafe_Management_System.All_User_Controls
{
    partial class uc_additem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_additem = new Guna.UI2.WinForms.Guna2Button();
            this.txt_category = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_itemname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(188, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Category";
            // 
            // btn_additem
            // 
            this.btn_additem.BorderRadius = 23;
            this.btn_additem.CheckedState.Parent = this.btn_additem;
            this.btn_additem.CustomImages.Parent = this.btn_additem;
            this.btn_additem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btn_additem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_additem.ForeColor = System.Drawing.Color.White;
            this.btn_additem.HoverState.Parent = this.btn_additem;
            this.btn_additem.Location = new System.Drawing.Point(234, 319);
            this.btn_additem.Name = "btn_additem";
            this.btn_additem.ShadowDecoration.Parent = this.btn_additem;
            this.btn_additem.Size = new System.Drawing.Size(161, 45);
            this.btn_additem.TabIndex = 4;
            this.btn_additem.Text = "Add Item";
            this.btn_additem.Click += new System.EventHandler(this.btn_additem_Click);
            // 
            // txt_category
            // 
            this.txt_category.BackColor = System.Drawing.Color.Transparent;
            this.txt_category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_category.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_category.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_category.FocusedState.Parent = this.txt_category;
            this.txt_category.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.txt_category.ForeColor = System.Drawing.Color.Black;
            this.txt_category.HoverState.Parent = this.txt_category;
            this.txt_category.ItemHeight = 30;
            this.txt_category.Items.AddRange(new object[] {
            "Sweets",
            "Fast Food",
            "Vegitable",
            "Packages!!!!!!",
            "Punjabi Foods",
            "Italian Foods",
            "Desi Foods",
            "Drinks"});
            this.txt_category.ItemsAppearance.Parent = this.txt_category;
            this.txt_category.Location = new System.Drawing.Point(186, 136);
            this.txt_category.Name = "txt_category";
            this.txt_category.ShadowDecoration.Parent = this.txt_category;
            this.txt_category.Size = new System.Drawing.Size(274, 36);
            this.txt_category.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_category.TabIndex = 5;
            this.txt_category.SelectedIndexChanged += new System.EventHandler(this.txt_category_SelectedIndexChanged);
            // 
            // txt_itemname
            // 
            this.txt_itemname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_itemname.DefaultText = "";
            this.txt_itemname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_itemname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_itemname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_itemname.DisabledState.Parent = this.txt_itemname;
            this.txt_itemname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_itemname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_itemname.FocusedState.Parent = this.txt_itemname;
            this.txt_itemname.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.txt_itemname.ForeColor = System.Drawing.Color.Black;
            this.txt_itemname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_itemname.HoverState.Parent = this.txt_itemname;
            this.txt_itemname.Location = new System.Drawing.Point(186, 197);
            this.txt_itemname.Margin = new System.Windows.Forms.Padding(6);
            this.txt_itemname.Name = "txt_itemname";
            this.txt_itemname.PasswordChar = '\0';
            this.txt_itemname.PlaceholderText = "";
            this.txt_itemname.SelectedText = "";
            this.txt_itemname.ShadowDecoration.Parent = this.txt_itemname;
            this.txt_itemname.Size = new System.Drawing.Size(274, 38);
            this.txt_itemname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_itemname.TabIndex = 6;
            // 
            // txt_price
            // 
            this.txt_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_price.DefaultText = "";
            this.txt_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_price.DisabledState.Parent = this.txt_price;
            this.txt_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_price.FocusedState.Parent = this.txt_price;
            this.txt_price.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.ForeColor = System.Drawing.Color.Black;
            this.txt_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_price.HoverState.Parent = this.txt_price;
            this.txt_price.Location = new System.Drawing.Point(186, 272);
            this.txt_price.Margin = new System.Windows.Forms.Padding(6);
            this.txt_price.Name = "txt_price";
            this.txt_price.PasswordChar = '\0';
            this.txt_price.PlaceholderText = "";
            this.txt_price.SelectedText = "";
            this.txt_price.ShadowDecoration.Parent = this.txt_price;
            this.txt_price.Size = new System.Drawing.Size(274, 38);
            this.txt_price.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_price.TabIndex = 7;
            this.txt_price.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 23;
            this.guna2Elipse1.TargetControl = this;
            // 
            // uc_additem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_itemname);
            this.Controls.Add(this.txt_category);
            this.Controls.Add(this.btn_additem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "uc_additem";
            this.Size = new System.Drawing.Size(781, 514);
            this.Load += new System.EventHandler(this.uc_additem_Load);
            this.Leave += new System.EventHandler(this.uc_additem_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btn_additem;
        private Guna.UI2.WinForms.Guna2ComboBox txt_category;
        private Guna.UI2.WinForms.Guna2TextBox txt_itemname;
        private Guna.UI2.WinForms.Guna2TextBox txt_price;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}

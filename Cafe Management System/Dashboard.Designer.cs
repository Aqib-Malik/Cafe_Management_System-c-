
namespace Cafe_Management_System
{
    partial class Dashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_user = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.LinkLabel();
            this.btn_exit = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.additem_btn = new Guna.UI2.WinForms.Guna2Button();
            this.updateitem_btn = new Guna.UI2.WinForms.Guna2Button();
            this.removeitem_btn = new Guna.UI2.WinForms.Guna2Button();
            this.placeorder_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_RemoveItem1 = new Cafe_Management_System.All_User_Controls.UC_RemoveItem();
            this.uC_Update_item1 = new Cafe_Management_System.All_User_Controls.UC_Update_item();
            this.uC_placerorder1 = new Cafe_Management_System.All_User_Controls.UC_placerorder();
            this.uc_additem1 = new Cafe_Management_System.All_User_Controls.uc_additem();
            this.userControl11 = new Cafe_Management_System.All_User_Controls.UserControl1();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse7 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.lbl_user);
            this.panel1.Controls.Add(this.logout_btn);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.additem_btn);
            this.panel1.Controls.Add(this.updateitem_btn);
            this.panel1.Controls.Add(this.removeitem_btn);
            this.panel1.Controls.Add(this.placeorder_btn);
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 525);
            this.panel1.TabIndex = 0;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lbl_user, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbl_user.Font = new System.Drawing.Font("Ravie", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_user.Location = new System.Drawing.Point(3, 63);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(100, 30);
            this.lbl_user.TabIndex = 6;
            this.lbl_user.Text = "Guest";
            this.lbl_user.Click += new System.EventHandler(this.lbl_user_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.ActiveLinkColor = System.Drawing.Color.White;
            this.logout_btn.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.logout_btn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.LinkColor = System.Drawing.Color.White;
            this.logout_btn.Location = new System.Drawing.Point(49, 464);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(77, 24);
            this.logout_btn.TabIndex = 5;
            this.logout_btn.TabStop = true;
            this.logout_btn.Text = "Log Out";
            this.logout_btn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logout_btn_LinkClicked);
            // 
            // btn_exit
            // 
            this.btn_exit.CheckedState.Parent = this.btn_exit;
            this.btn_exit.CustomImages.Parent = this.btn_exit;
            this.guna2Transition1.SetDecoration(this.btn_exit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.HoverState.Parent = this.btn_exit;
            this.btn_exit.Location = new System.Drawing.Point(3, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_exit.ShadowDecoration.Parent = this.btn_exit;
            this.btn_exit.Size = new System.Drawing.Size(38, 38);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "X";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // additem_btn
            // 
            this.additem_btn.BorderRadius = 15;
            this.additem_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.additem_btn.CheckedState.FillColor = System.Drawing.Color.White;
            this.additem_btn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.additem_btn.CheckedState.Parent = this.additem_btn;
            this.additem_btn.CustomImages.Parent = this.additem_btn;
            this.guna2Transition1.SetDecoration(this.additem_btn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.additem_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.additem_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additem_btn.ForeColor = System.Drawing.Color.White;
            this.additem_btn.HoverState.Parent = this.additem_btn;
            this.additem_btn.Location = new System.Drawing.Point(22, 179);
            this.additem_btn.Name = "additem_btn";
            this.additem_btn.ShadowDecoration.Parent = this.additem_btn;
            this.additem_btn.Size = new System.Drawing.Size(202, 41);
            this.additem_btn.TabIndex = 3;
            this.additem_btn.Text = "Add Items";
            this.additem_btn.Click += new System.EventHandler(this.additem_btn_Click);
            // 
            // updateitem_btn
            // 
            this.updateitem_btn.BorderRadius = 15;
            this.updateitem_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.updateitem_btn.CheckedState.FillColor = System.Drawing.Color.White;
            this.updateitem_btn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.updateitem_btn.CheckedState.Parent = this.updateitem_btn;
            this.updateitem_btn.CustomImages.Parent = this.updateitem_btn;
            this.guna2Transition1.SetDecoration(this.updateitem_btn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.updateitem_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.updateitem_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateitem_btn.ForeColor = System.Drawing.Color.White;
            this.updateitem_btn.HoverState.Parent = this.updateitem_btn;
            this.updateitem_btn.Location = new System.Drawing.Point(22, 237);
            this.updateitem_btn.Name = "updateitem_btn";
            this.updateitem_btn.ShadowDecoration.Parent = this.updateitem_btn;
            this.updateitem_btn.Size = new System.Drawing.Size(202, 41);
            this.updateitem_btn.TabIndex = 2;
            this.updateitem_btn.Text = "Update Items";
            this.updateitem_btn.Click += new System.EventHandler(this.updateitem_btn_Click);
            // 
            // removeitem_btn
            // 
            this.removeitem_btn.BorderRadius = 15;
            this.removeitem_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.removeitem_btn.CheckedState.FillColor = System.Drawing.Color.White;
            this.removeitem_btn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.removeitem_btn.CheckedState.Parent = this.removeitem_btn;
            this.removeitem_btn.CustomImages.Parent = this.removeitem_btn;
            this.guna2Transition1.SetDecoration(this.removeitem_btn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.removeitem_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.removeitem_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeitem_btn.ForeColor = System.Drawing.Color.White;
            this.removeitem_btn.HoverState.Parent = this.removeitem_btn;
            this.removeitem_btn.Location = new System.Drawing.Point(22, 296);
            this.removeitem_btn.Name = "removeitem_btn";
            this.removeitem_btn.ShadowDecoration.Parent = this.removeitem_btn;
            this.removeitem_btn.Size = new System.Drawing.Size(202, 41);
            this.removeitem_btn.TabIndex = 1;
            this.removeitem_btn.Text = "Remove Items";
            this.removeitem_btn.Click += new System.EventHandler(this.removeitem_btn_Click);
            // 
            // placeorder_btn
            // 
            this.placeorder_btn.BorderRadius = 15;
            this.placeorder_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.placeorder_btn.CheckedState.FillColor = System.Drawing.Color.White;
            this.placeorder_btn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.placeorder_btn.CheckedState.Parent = this.placeorder_btn;
            this.placeorder_btn.CustomImages.Parent = this.placeorder_btn;
            this.guna2Transition1.SetDecoration(this.placeorder_btn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.placeorder_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.placeorder_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeorder_btn.ForeColor = System.Drawing.Color.White;
            this.placeorder_btn.HoverState.Parent = this.placeorder_btn;
            this.placeorder_btn.Location = new System.Drawing.Point(22, 115);
            this.placeorder_btn.Name = "placeorder_btn";
            this.placeorder_btn.ShadowDecoration.Parent = this.placeorder_btn;
            this.placeorder_btn.Size = new System.Drawing.Size(202, 42);
            this.placeorder_btn.TabIndex = 0;
            this.placeorder_btn.Text = "Place Order";
            this.placeorder_btn.Click += new System.EventHandler(this.placeorder_btn_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.uC_RemoveItem1);
            this.panel2.Controls.Add(this.uC_Update_item1);
            this.panel2.Controls.Add(this.uC_placerorder1);
            this.panel2.Controls.Add(this.uc_additem1);
            this.panel2.Controls.Add(this.userControl11);
            this.guna2Transition1.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(210, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 525);
            this.panel2.TabIndex = 1;
            // 
            // uC_RemoveItem1
            // 
            this.guna2Transition1.SetDecoration(this.uC_RemoveItem1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_RemoveItem1.Location = new System.Drawing.Point(3, 3);
            this.uC_RemoveItem1.Name = "uC_RemoveItem1";
            this.uC_RemoveItem1.Size = new System.Drawing.Size(781, 514);
            this.uC_RemoveItem1.TabIndex = 4;
            // 
            // uC_Update_item1
            // 
            this.uC_Update_item1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_Update_item1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_Update_item1.Location = new System.Drawing.Point(3, 3);
            this.uC_Update_item1.Name = "uC_Update_item1";
            this.uC_Update_item1.Size = new System.Drawing.Size(781, 514);
            this.uC_Update_item1.TabIndex = 3;
            // 
            // uC_placerorder1
            // 
            this.uC_placerorder1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_placerorder1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_placerorder1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_placerorder1.ForeColor = System.Drawing.Color.Black;
            this.uC_placerorder1.Location = new System.Drawing.Point(3, 8);
            this.uC_placerorder1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_placerorder1.Name = "uC_placerorder1";
            this.uC_placerorder1.Size = new System.Drawing.Size(1172, 712);
            this.uC_placerorder1.TabIndex = 2;
            // 
            // uc_additem1
            // 
            this.guna2Transition1.SetDecoration(this.uc_additem1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uc_additem1.Location = new System.Drawing.Point(9, 8);
            this.uc_additem1.Name = "uc_additem1";
            this.uc_additem1.Size = new System.Drawing.Size(782, 514);
            this.uc_additem1.TabIndex = 1;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.userControl11, Guna.UI2.AnimatorNS.DecorationType.None);
            this.userControl11.Location = new System.Drawing.Point(3, 8);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(781, 514);
            this.userControl11.TabIndex = 0;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this.panel2;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.ScaleAndHorizSlide;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            this.guna2Transition1.MaxAnimationTime = 3000;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.BorderRadius = 30;
            this.guna2Elipse6.TargetControl = this.panel2;
            // 
            // guna2Elipse7
            // 
            this.guna2Elipse7.BorderRadius = 30;
            this.guna2Elipse7.TargetControl = this.panel2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1004, 538);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button placeorder_btn;
        private Guna.UI2.WinForms.Guna2Button additem_btn;
        private Guna.UI2.WinForms.Guna2Button updateitem_btn;
        private Guna.UI2.WinForms.Guna2Button removeitem_btn;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btn_exit;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.LinkLabel logout_btn;
        private All_User_Controls.UserControl1 userControl11;
        private All_User_Controls.uc_additem uc_additem1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private All_User_Controls.UC_placerorder uC_placerorder1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private All_User_Controls.UC_Update_item uC_Update_item1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse7;
        private All_User_Controls.UC_RemoveItem uC_RemoveItem1;
        private System.Windows.Forms.Label lbl_user;
    }
}
namespace prjQLNK
{
    partial class frmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
            this.radMKC2 = new System.Windows.Forms.RadioButton();
            this.radMKC1 = new System.Windows.Forms.RadioButton();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.txtNLMK = new DevExpress.XtraEditors.TextEdit();
            this.txtMKM = new DevExpress.XtraEditors.TextEdit();
            this.txtMKC = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNLMK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // radMKC2
            // 
            this.radMKC2.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radMKC2.Location = new System.Drawing.Point(199, 12);
            this.radMKC2.Name = "radMKC2";
            this.radMKC2.Size = new System.Drawing.Size(184, 25);
            this.radMKC2.TabIndex = 33;
            this.radMKC2.Text = "Mật khẩu cấp 2";
            this.radMKC2.UseVisualStyleBackColor = true;
            // 
            // radMKC1
            // 
            this.radMKC1.Checked = true;
            this.radMKC1.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radMKC1.Location = new System.Drawing.Point(12, 12);
            this.radMKC1.Name = "radMKC1";
            this.radMKC1.Size = new System.Drawing.Size(183, 25);
            this.radMKC1.TabIndex = 32;
            this.radMKC1.TabStop = true;
            this.radMKC1.Text = "Mật khẩu cấp 1";
            this.radMKC1.UseVisualStyleBackColor = true;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.txtNLMK);
            this.layoutControl2.Controls.Add(this.txtMKM);
            this.layoutControl2.Controls.Add(this.txtMKC);
            this.layoutControl2.Controls.Add(this.simpleButton2);
            this.layoutControl2.Controls.Add(this.simpleButton1);
            this.layoutControl2.Controls.Add(this.radMKC2);
            this.layoutControl2.Controls.Add(this.radMKC1);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(395, 150);
            this.layoutControl2.TabIndex = 2;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // txtNLMK
            // 
            this.txtNLMK.Location = new System.Drawing.Point(104, 89);
            this.txtNLMK.Name = "txtNLMK";
            this.txtNLMK.Properties.PasswordChar = '*';
            this.txtNLMK.Size = new System.Drawing.Size(279, 20);
            this.txtNLMK.StyleController = this.layoutControl2;
            this.txtNLMK.TabIndex = 38;
            // 
            // txtMKM
            // 
            this.txtMKM.Location = new System.Drawing.Point(104, 65);
            this.txtMKM.Name = "txtMKM";
            this.txtMKM.Properties.PasswordChar = '*';
            this.txtMKM.Size = new System.Drawing.Size(279, 20);
            this.txtMKM.StyleController = this.layoutControl2;
            this.txtMKM.TabIndex = 37;
            // 
            // txtMKC
            // 
            this.txtMKC.Location = new System.Drawing.Point(104, 41);
            this.txtMKC.Name = "txtMKC";
            this.txtMKC.Properties.PasswordChar = '*';
            this.txtMKC.Size = new System.Drawing.Size(279, 20);
            this.txtMKC.StyleController = this.layoutControl2;
            this.txtMKC.TabIndex = 36;
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(199, 113);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(184, 22);
            this.simpleButton2.StyleController = this.layoutControl2;
            this.simpleButton2.TabIndex = 35;
            this.simpleButton2.Text = "Nhập lại";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 113);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(183, 22);
            this.simpleButton1.StyleController = this.layoutControl2;
            this.simpleButton1.TabIndex = 34;
            this.simpleButton1.Text = "Chấp nhận";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem8});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(395, 150);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.radMKC1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(187, 29);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.simpleButton1;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 101);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(187, 29);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.simpleButton2;
            this.layoutControlItem11.Location = new System.Drawing.Point(187, 101);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(188, 29);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.radMKC2;
            this.layoutControlItem4.Location = new System.Drawing.Point(187, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(188, 29);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtMKC;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 29);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(375, 24);
            this.layoutControlItem1.Text = "Mật khẩu cũ:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(89, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtMKM;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 53);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(375, 24);
            this.layoutControlItem2.Text = "Mật khẩu mới:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(89, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtNLMK;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 77);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(375, 24);
            this.layoutControlItem8.Text = "Nhập lại mật khẩu:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(89, 13);
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 150);
            this.Controls.Add(this.layoutControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDoiMatKhau";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNLMK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton radMKC2;
        private System.Windows.Forms.RadioButton radMKC1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraEditors.TextEdit txtNLMK;
        private DevExpress.XtraEditors.TextEdit txtMKM;
        private DevExpress.XtraEditors.TextEdit txtMKC;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}

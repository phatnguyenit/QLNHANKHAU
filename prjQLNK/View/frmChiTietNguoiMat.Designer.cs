namespace prjQLNK
{
    partial class frmChiTietNguoiMat
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblNgayKhai = new System.Windows.Forms.Label();
            this.lblNguoilap = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.txtGhichu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNguoikhai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dpkNgaymat = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtLydomat = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpkNgaymat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblNgayKhai);
            this.groupControl1.Controls.Add(this.lblNguoilap);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Controls.Add(this.txtGhichu);
            this.groupControl1.Controls.Add(this.txtNguoikhai);
            this.groupControl1.Controls.Add(this.dpkNgaymat);
            this.groupControl1.Controls.Add(this.txtLydomat);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label18);
            this.groupControl1.Controls.Add(this.label16);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(660, 166);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông tin người mất";
            // 
            // lblNgayKhai
            // 
            this.lblNgayKhai.BackColor = System.Drawing.Color.Cyan;
            this.lblNgayKhai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNgayKhai.Location = new System.Drawing.Point(85, 88);
            this.lblNgayKhai.Name = "lblNgayKhai";
            this.lblNgayKhai.Size = new System.Drawing.Size(231, 20);
            this.lblNgayKhai.TabIndex = 372;
            this.lblNgayKhai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNguoilap
            // 
            this.lblNguoilap.BackColor = System.Drawing.Color.Cyan;
            this.lblNguoilap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNguoilap.ForeColor = System.Drawing.Color.Black;
            this.lblNguoilap.Location = new System.Drawing.Point(414, 87);
            this.lblNguoilap.Name = "lblNguoilap";
            this.lblNguoilap.Size = new System.Drawing.Size(231, 21);
            this.lblNguoilap.TabIndex = 371;
            this.lblNguoilap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDong);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Location = new System.Drawing.Point(15, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 45);
            this.groupBox1.TabIndex = 370;
            this.groupBox1.TabStop = false;
            // 
            // btnDong
            // 
            this.btnDong.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDong.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDong.Appearance.Options.UseFont = true;
            this.btnDong.Appearance.Options.UseForeColor = true;
            this.btnDong.ImageOptions.Image = global::prjQLNK.Properties.Resources.Close;
            this.btnDong.Location = new System.Drawing.Point(328, 13);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(295, 25);
            this.btnDong.TabIndex = 356;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Appearance.Options.UseForeColor = true;
            this.btnSua.ImageOptions.Image = global::prjQLNK.Properties.Resources.edit;
            this.btnSua.Location = new System.Drawing.Point(6, 13);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(295, 25);
            this.btnSua.TabIndex = 355;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtGhichu
            // 
            // 
            // 
            // 
            this.txtGhichu.Border.Class = "TextBoxBorder";
            this.txtGhichu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGhichu.Enabled = false;
            this.txtGhichu.Location = new System.Drawing.Point(85, 59);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.PreventEnterBeep = true;
            this.txtGhichu.Size = new System.Drawing.Size(231, 21);
            this.txtGhichu.TabIndex = 368;
            this.txtGhichu.WatermarkText = "Ghi chú";
            // 
            // txtNguoikhai
            // 
            // 
            // 
            // 
            this.txtNguoikhai.Border.Class = "TextBoxBorder";
            this.txtNguoikhai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNguoikhai.Enabled = false;
            this.txtNguoikhai.Location = new System.Drawing.Point(414, 60);
            this.txtNguoikhai.Name = "txtNguoikhai";
            this.txtNguoikhai.PreventEnterBeep = true;
            this.txtNguoikhai.Size = new System.Drawing.Size(231, 21);
            this.txtNguoikhai.TabIndex = 367;
            this.txtNguoikhai.WatermarkText = "Người khai báo";
            // 
            // dpkNgaymat
            // 
            // 
            // 
            // 
            this.dpkNgaymat.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dpkNgaymat.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dpkNgaymat.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dpkNgaymat.ButtonDropDown.Visible = true;
            this.dpkNgaymat.Enabled = false;
            this.dpkNgaymat.IsPopupCalendarOpen = false;
            this.dpkNgaymat.Location = new System.Drawing.Point(85, 33);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dpkNgaymat.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dpkNgaymat.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dpkNgaymat.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dpkNgaymat.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dpkNgaymat.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dpkNgaymat.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dpkNgaymat.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dpkNgaymat.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dpkNgaymat.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dpkNgaymat.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dpkNgaymat.MonthCalendar.DisplayMonth = new System.DateTime(2015, 11, 1, 0, 0, 0, 0);
            this.dpkNgaymat.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dpkNgaymat.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dpkNgaymat.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dpkNgaymat.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dpkNgaymat.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dpkNgaymat.MonthCalendar.TodayButtonVisible = true;
            this.dpkNgaymat.Name = "dpkNgaymat";
            this.dpkNgaymat.Size = new System.Drawing.Size(231, 21);
            this.dpkNgaymat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dpkNgaymat.TabIndex = 365;
            this.dpkNgaymat.WatermarkText = "Ngày/Tháng/Năm";
            // 
            // txtLydomat
            // 
            // 
            // 
            // 
            this.txtLydomat.Border.Class = "TextBoxBorder";
            this.txtLydomat.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLydomat.Enabled = false;
            this.txtLydomat.Location = new System.Drawing.Point(414, 33);
            this.txtLydomat.Name = "txtLydomat";
            this.txtLydomat.PreventEnterBeep = true;
            this.txtLydomat.Size = new System.Drawing.Size(231, 21);
            this.txtLydomat.TabIndex = 364;
            this.txtLydomat.WatermarkText = "Lý do mất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 360;
            this.label3.Text = "Ghi chú:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 358;
            this.label1.Text = "Người khai:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 359;
            this.label4.Text = "Ngày khai:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 363;
            this.label2.Text = "Cán bộ lập:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(340, 36);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 15);
            this.label18.TabIndex = 361;
            this.label18.Text = "Lý do mất:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 15);
            this.label16.TabIndex = 362;
            this.label16.Text = "Ngày mất:";
            // 
            // frmChiTietNguoiMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 166);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.Name = "frmChiTietNguoiMat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin";
            this.Load += new System.EventHandler(this.frmChiTietNguoiMat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dpkNgaymat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGhichu;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNguoikhai;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dpkNgaymat;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLydomat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private System.Windows.Forms.Label lblNguoilap;
        private System.Windows.Forms.Label lblNgayKhai;
    }
}
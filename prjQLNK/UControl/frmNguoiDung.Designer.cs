namespace prjQLNK
{
    partial class frmThongTinNguoiDung
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.gridCanBo = new DevExpress.XtraGrid.GridControl();
            this.BangNguoiDung = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MACANBO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENCANBO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIOITINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CHUCVU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QUYENHAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pannelThongTin = new DevExpress.XtraEditors.PanelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtChucvu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSDT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDiachi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtHoten = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaso = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dpkNgaySinh = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cboQuyenhan = new System.Windows.Forms.ComboBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblMaso = new DevComponents.DotNetBar.LabelX();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCanBo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BangNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pannelThongTin)).BeginInit();
            this.pannelThongTin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpkNgaySinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.panelControl2);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(904, 328);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "DANH SÁCH NGƯỜI DÙNG";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Controls.Add(this.pannelThongTin);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(140, 21);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(762, 305);
            this.panelControl2.TabIndex = 1;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.gridCanBo);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(2, 131);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(758, 172);
            this.panelControl4.TabIndex = 1;
            // 
            // gridCanBo
            // 
            this.gridCanBo.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.gridCanBo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCanBo.Location = new System.Drawing.Point(2, 2);
            this.gridCanBo.MainView = this.BangNguoiDung;
            this.gridCanBo.Name = "gridCanBo";
            this.gridCanBo.Size = new System.Drawing.Size(754, 168);
            this.gridCanBo.TabIndex = 10;
            this.gridCanBo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.BangNguoiDung});
            // 
            // BangNguoiDung
            // 
            this.BangNguoiDung.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MACANBO,
            this.TENCANBO,
            this.GIOITINH,
            this.NGAYSINH,
            this.CHUCVU,
            this.DIACHI,
            this.SDT,
            this.EMAIL,
            this.QUYENHAN});
            this.BangNguoiDung.GridControl = this.gridCanBo;
            this.BangNguoiDung.Name = "BangNguoiDung";
            this.BangNguoiDung.OptionsBehavior.Editable = false;
            this.BangNguoiDung.OptionsPrint.PrintPreview = true;
            this.BangNguoiDung.OptionsPrint.PrintSelectedRowsOnly = true;
            this.BangNguoiDung.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.BangNguoiDung.OptionsSelection.MultiSelect = true;
            this.BangNguoiDung.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.BangNguoiDung.OptionsView.ShowFooter = true;
            this.BangNguoiDung.OptionsView.ShowGroupPanel = false;
            this.BangNguoiDung.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.BangNguoiDung_FocusedRowChanged);
            // 
            // MACANBO
            // 
            this.MACANBO.AppearanceCell.Options.UseTextOptions = true;
            this.MACANBO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MACANBO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.MACANBO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.MACANBO.AppearanceHeader.Options.UseFont = true;
            this.MACANBO.AppearanceHeader.Options.UseTextOptions = true;
            this.MACANBO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MACANBO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.MACANBO.Caption = "Mã Số";
            this.MACANBO.FieldName = "MACANBO";
            this.MACANBO.Name = "MACANBO";
            this.MACANBO.Visible = true;
            this.MACANBO.VisibleIndex = 0;
            this.MACANBO.Width = 47;
            // 
            // TENCANBO
            // 
            this.TENCANBO.AppearanceCell.Options.UseTextOptions = true;
            this.TENCANBO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TENCANBO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TENCANBO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TENCANBO.AppearanceHeader.Options.UseFont = true;
            this.TENCANBO.AppearanceHeader.Options.UseTextOptions = true;
            this.TENCANBO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TENCANBO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TENCANBO.Caption = "Họ Tên";
            this.TENCANBO.FieldName = "TENCANBO";
            this.TENCANBO.Name = "TENCANBO";
            this.TENCANBO.Visible = true;
            this.TENCANBO.VisibleIndex = 1;
            this.TENCANBO.Width = 117;
            // 
            // GIOITINH
            // 
            this.GIOITINH.AppearanceCell.Options.UseTextOptions = true;
            this.GIOITINH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GIOITINH.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GIOITINH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.GIOITINH.AppearanceHeader.Options.UseFont = true;
            this.GIOITINH.AppearanceHeader.Options.UseTextOptions = true;
            this.GIOITINH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GIOITINH.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GIOITINH.Caption = "Giới Tính";
            this.GIOITINH.FieldName = "GIOITINH";
            this.GIOITINH.Name = "GIOITINH";
            this.GIOITINH.Visible = true;
            this.GIOITINH.VisibleIndex = 2;
            this.GIOITINH.Width = 55;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.AppearanceCell.Options.UseTextOptions = true;
            this.NGAYSINH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGAYSINH.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NGAYSINH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.NGAYSINH.AppearanceHeader.Options.UseFont = true;
            this.NGAYSINH.AppearanceHeader.Options.UseTextOptions = true;
            this.NGAYSINH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NGAYSINH.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NGAYSINH.Caption = "Ngày Sinh";
            this.NGAYSINH.FieldName = "NGAYSINH";
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.Visible = true;
            this.NGAYSINH.VisibleIndex = 3;
            this.NGAYSINH.Width = 71;
            // 
            // CHUCVU
            // 
            this.CHUCVU.AppearanceCell.Options.UseTextOptions = true;
            this.CHUCVU.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CHUCVU.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CHUCVU.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.CHUCVU.AppearanceHeader.Options.UseFont = true;
            this.CHUCVU.AppearanceHeader.Options.UseTextOptions = true;
            this.CHUCVU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CHUCVU.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CHUCVU.Caption = "Chức Vụ";
            this.CHUCVU.FieldName = "CHUCVU";
            this.CHUCVU.Name = "CHUCVU";
            this.CHUCVU.Visible = true;
            this.CHUCVU.VisibleIndex = 7;
            this.CHUCVU.Width = 74;
            // 
            // DIACHI
            // 
            this.DIACHI.AppearanceCell.Options.UseTextOptions = true;
            this.DIACHI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DIACHI.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.DIACHI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DIACHI.AppearanceHeader.Options.UseFont = true;
            this.DIACHI.AppearanceHeader.Options.UseTextOptions = true;
            this.DIACHI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DIACHI.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.DIACHI.Caption = "Địa Chỉ";
            this.DIACHI.FieldName = "DIACHI";
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Visible = true;
            this.DIACHI.VisibleIndex = 4;
            this.DIACHI.Width = 118;
            // 
            // SDT
            // 
            this.SDT.AppearanceCell.Options.UseTextOptions = true;
            this.SDT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SDT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SDT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.SDT.AppearanceHeader.Options.UseFont = true;
            this.SDT.AppearanceHeader.Options.UseTextOptions = true;
            this.SDT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SDT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SDT.Caption = "Điện Thoại";
            this.SDT.FieldName = "SDT";
            this.SDT.Name = "SDT";
            this.SDT.Visible = true;
            this.SDT.VisibleIndex = 5;
            this.SDT.Width = 76;
            // 
            // EMAIL
            // 
            this.EMAIL.AppearanceCell.Options.UseTextOptions = true;
            this.EMAIL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.EMAIL.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.EMAIL.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.EMAIL.AppearanceHeader.Options.UseFont = true;
            this.EMAIL.AppearanceHeader.Options.UseTextOptions = true;
            this.EMAIL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.EMAIL.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.EMAIL.Caption = "Email";
            this.EMAIL.FieldName = "EMAIL";
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Visible = true;
            this.EMAIL.VisibleIndex = 6;
            this.EMAIL.Width = 117;
            // 
            // QUYENHAN
            // 
            this.QUYENHAN.AppearanceCell.Options.UseTextOptions = true;
            this.QUYENHAN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QUYENHAN.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QUYENHAN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.QUYENHAN.AppearanceHeader.Options.UseFont = true;
            this.QUYENHAN.AppearanceHeader.Options.UseTextOptions = true;
            this.QUYENHAN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QUYENHAN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QUYENHAN.Caption = "Quyền Hạn";
            this.QUYENHAN.FieldName = "QUYENHAN";
            this.QUYENHAN.Name = "QUYENHAN";
            this.QUYENHAN.Visible = true;
            this.QUYENHAN.VisibleIndex = 8;
            this.QUYENHAN.Width = 80;
            // 
            // pannelThongTin
            // 
            this.pannelThongTin.Controls.Add(this.groupBox1);
            this.pannelThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pannelThongTin.Enabled = false;
            this.pannelThongTin.Location = new System.Drawing.Point(2, 2);
            this.pannelThongTin.Name = "pannelThongTin";
            this.pannelThongTin.Size = new System.Drawing.Size(758, 129);
            this.pannelThongTin.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtChucvu);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.txtMaso);
            this.groupBox1.Controls.Add(this.dpkNgaySinh);
            this.groupBox1.Controls.Add(this.radNam);
            this.groupBox1.Controls.Add(this.radNu);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.cboQuyenhan);
            this.groupBox1.Controls.Add(this.labelControl10);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.labelControl9);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.lblMaso);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(2, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtChucvu
            // 
            // 
            // 
            // 
            this.txtChucvu.Border.Class = "TextBoxBorder";
            this.txtChucvu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtChucvu.Location = new System.Drawing.Point(605, 56);
            this.txtChucvu.MaxLength = 100;
            this.txtChucvu.Name = "txtChucvu";
            this.txtChucvu.PreventEnterBeep = true;
            this.txtChucvu.Size = new System.Drawing.Size(153, 21);
            this.txtChucvu.TabIndex = 436;
            this.txtChucvu.WatermarkText = "Chức vụ";
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.Border.Class = "TextBoxBorder";
            this.txtEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmail.Location = new System.Drawing.Point(605, 28);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PreventEnterBeep = true;
            this.txtEmail.Size = new System.Drawing.Size(153, 21);
            this.txtEmail.TabIndex = 435;
            this.txtEmail.WatermarkText = "Địa chỉ Email";
            // 
            // txtSDT
            // 
            // 
            // 
            // 
            this.txtSDT.Border.Class = "TextBoxBorder";
            this.txtSDT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSDT.Location = new System.Drawing.Point(342, 83);
            this.txtSDT.MaxLength = 13;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PreventEnterBeep = true;
            this.txtSDT.Size = new System.Drawing.Size(153, 21);
            this.txtSDT.TabIndex = 434;
            this.txtSDT.WatermarkText = "Số điện thoại";
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress_1);
            // 
            // txtDiachi
            // 
            // 
            // 
            // 
            this.txtDiachi.Border.Class = "TextBoxBorder";
            this.txtDiachi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDiachi.Location = new System.Drawing.Point(342, 55);
            this.txtDiachi.MaxLength = 100;
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.PreventEnterBeep = true;
            this.txtDiachi.Size = new System.Drawing.Size(153, 21);
            this.txtDiachi.TabIndex = 433;
            this.txtDiachi.WatermarkText = "Địa chỉ";
            // 
            // txtHoten
            // 
            // 
            // 
            // 
            this.txtHoten.Border.Class = "TextBoxBorder";
            this.txtHoten.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtHoten.Location = new System.Drawing.Point(71, 57);
            this.txtHoten.MaxLength = 100;
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.PreventEnterBeep = true;
            this.txtHoten.Size = new System.Drawing.Size(155, 21);
            this.txtHoten.TabIndex = 432;
            this.txtHoten.WatermarkText = "Họ tên";
            // 
            // txtMaso
            // 
            // 
            // 
            // 
            this.txtMaso.Border.Class = "TextBoxBorder";
            this.txtMaso.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaso.Location = new System.Drawing.Point(71, 27);
            this.txtMaso.MaxLength = 10;
            this.txtMaso.Name = "txtMaso";
            this.txtMaso.PreventEnterBeep = true;
            this.txtMaso.Size = new System.Drawing.Size(155, 21);
            this.txtMaso.TabIndex = 431;
            this.txtMaso.Visible = false;
            this.txtMaso.WatermarkText = "Mã số";
            // 
            // dpkNgaySinh
            // 
            // 
            // 
            // 
            this.dpkNgaySinh.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dpkNgaySinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dpkNgaySinh.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dpkNgaySinh.ButtonDropDown.Visible = true;
            this.dpkNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dpkNgaySinh.IsPopupCalendarOpen = false;
            this.dpkNgaySinh.Location = new System.Drawing.Point(342, 28);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dpkNgaySinh.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dpkNgaySinh.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dpkNgaySinh.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dpkNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dpkNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dpkNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dpkNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dpkNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dpkNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dpkNgaySinh.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dpkNgaySinh.MonthCalendar.DisplayMonth = new System.DateTime(2015, 10, 1, 0, 0, 0, 0);
            this.dpkNgaySinh.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dpkNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dpkNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dpkNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dpkNgaySinh.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dpkNgaySinh.MonthCalendar.TodayButtonVisible = true;
            this.dpkNgaySinh.Name = "dpkNgaySinh";
            this.dpkNgaySinh.Size = new System.Drawing.Size(153, 21);
            this.dpkNgaySinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dpkNgaySinh.TabIndex = 3;
            this.dpkNgaySinh.WatermarkText = "Ngày/Tháng/Năm";
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Checked = true;
            this.radNam.Location = new System.Drawing.Point(98, 87);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(46, 17);
            this.radNam.TabIndex = 2;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(164, 87);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(39, 17);
            this.radNu.TabIndex = 430;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Location = new System.Drawing.Point(71, 86);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(155, 20);
            this.labelControl1.TabIndex = 428;
            // 
            // cboQuyenhan
            // 
            this.cboQuyenhan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboQuyenhan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboQuyenhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuyenhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboQuyenhan.FormattingEnabled = true;
            this.cboQuyenhan.Items.AddRange(new object[] {
            "Quản lý",
            "Người dùng",
            "Tạm khóa"});
            this.cboQuyenhan.Location = new System.Drawing.Point(605, 83);
            this.cboQuyenhan.Name = "cboQuyenhan";
            this.cboQuyenhan.Size = new System.Drawing.Size(153, 21);
            this.cboQuyenhan.TabIndex = 8;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(537, 86);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(64, 14);
            this.labelControl10.TabIndex = 423;
            this.labelControl10.Text = "Quyền hạn:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(277, 85);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(59, 14);
            this.labelControl7.TabIndex = 422;
            this.labelControl7.Text = "Điện thoại:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(537, 58);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(49, 14);
            this.labelControl9.TabIndex = 421;
            this.labelControl9.Text = "Chức vụ:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(17, 89);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 426;
            this.labelControl4.Text = "Giới tính:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(537, 31);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(31, 14);
            this.labelControl8.TabIndex = 425;
            this.labelControl8.Text = "Email:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(278, 57);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(39, 14);
            this.labelControl6.TabIndex = 424;
            this.labelControl6.Text = "Địa chỉ:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(278, 30);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 14);
            this.labelControl5.TabIndex = 418;
            this.labelControl5.Text = "Ngày sinh:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(17, 58);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 14);
            this.labelControl3.TabIndex = 419;
            this.labelControl3.Text = "Họ tên:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(17, 29);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 14);
            this.labelControl2.TabIndex = 420;
            this.labelControl2.Text = "Mã số:";
            // 
            // lblMaso
            // 
            this.lblMaso.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.lblMaso.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblMaso.Location = new System.Drawing.Point(71, 27);
            this.lblMaso.Name = "lblMaso";
            this.lblMaso.Size = new System.Drawing.Size(153, 20);
            this.lblMaso.TabIndex = 411;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnHuy);
            this.panelControl1.Controls.Add(this.btnXoa);
            this.panelControl1.Controls.Add(this.btnSua);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(2, 21);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(138, 305);
            this.panelControl1.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Enabled = false;
            this.btnHuy.ImageOptions.Image = global::prjQLNK.Properties.Resources.cancel;
            this.btnHuy.Location = new System.Drawing.Point(18, 85);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(102, 28);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = global::prjQLNK.Properties.Resources.Close;
            this.btnXoa.Location = new System.Drawing.Point(18, 51);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 28);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.ImageOptions.Image = global::prjQLNK.Properties.Resources.edit;
            this.btnSua.Location = new System.Drawing.Point(18, 17);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(102, 28);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // frmThongTinNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 328);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmThongTinNguoiDung";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ NGƯỜI DÙNG";
            this.Load += new System.EventHandler(this.frmThongTinNguoiDung_Load);
            this.Leave += new System.EventHandler(this.frmThongTinNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCanBo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BangNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pannelThongTin)).EndInit();
            this.pannelThongTin.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpkNgaySinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraGrid.GridControl gridCanBo;
        private DevExpress.XtraGrid.Views.Grid.GridView BangNguoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn MACANBO;
        private DevExpress.XtraGrid.Columns.GridColumn TENCANBO;
        private DevExpress.XtraGrid.Columns.GridColumn GIOITINH;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn CHUCVU;
        private DevExpress.XtraGrid.Columns.GridColumn DIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn SDT;
        private DevExpress.XtraGrid.Columns.GridColumn EMAIL;
        private DevExpress.XtraGrid.Columns.GridColumn QUYENHAN;
        private DevExpress.XtraEditors.PanelControl pannelThongTin;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cboQuyenhan;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevComponents.DotNetBar.LabelX lblMaso;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dpkNgaySinh;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaso;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiachi;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHoten;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSDT;
        private DevComponents.DotNetBar.Controls.TextBoxX txtChucvu;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEmail;


    }
}

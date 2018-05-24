namespace prjQLNK
{
    partial class frmNhapKhau
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
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapKhau));
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions2 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions3 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions4 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.xpNHAPKHAU = new DevExpress.Xpo.XPCollection(this.components);
            this.unitNHAPKHAU = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHAISINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboSODINHDANH = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.xpNHANKHAU = new DevExpress.Xpo.XPCollection(this.components);
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOHOKHAUHT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOHOKHAUNHAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboHoKhau = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.xpHOKHAU = new DevExpress.Xpo.XPCollection(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQUANHEVOICH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYNHAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.cboGT = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpNHAPKHAU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitNHAPKHAU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSODINHDANH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpNHANKHAU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboHoKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpHOKHAU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1042, 514);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpNHAPKHAU;
            this.gridControl1.Location = new System.Drawing.Point(24, 43);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboGT,
            this.repositoryItemDateEdit1,
            this.cboSODINHDANH,
            this.repositoryItemDateEdit2,
            this.cboHoKhau});
            this.gridControl1.Size = new System.Drawing.Size(994, 447);
            this.gridControl1.TabIndex = 384;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xpNHAPKHAU
            // 
            this.xpNHAPKHAU.DeleteObjectOnRemove = true;
            this.xpNHAPKHAU.ObjectType = typeof(prjQLNK.QLNK.NHAPKHAU);
            this.xpNHAPKHAU.Session = this.unitNHAPKHAU;
            // 
            // unitNHAPKHAU
            // 
            this.unitNHAPKHAU.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.unitNHAPKHAU.TrackPropertiesModifications = false;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colMAKHAISINH,
            this.colSOHOKHAUHT,
            this.colSOHOKHAUNHAP,
            this.colQUANHEVOICH,
            this.colNGAYNHAP});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "Nhập thông tin cần tìm ...";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridView1_PopupMenuShowing);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ShowInCustomizationForm = false;
            this.colID.OptionsColumn.ShowInExpressionEditor = false;
            // 
            // colMAKHAISINH
            // 
            this.colMAKHAISINH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMAKHAISINH.AppearanceHeader.Options.UseFont = true;
            this.colMAKHAISINH.AppearanceHeader.Options.UseTextOptions = true;
            this.colMAKHAISINH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAKHAISINH.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMAKHAISINH.Caption = "Họ tên khai sinh";
            this.colMAKHAISINH.ColumnEdit = this.cboSODINHDANH;
            this.colMAKHAISINH.FieldName = "MAKHAISINH";
            this.colMAKHAISINH.Name = "colMAKHAISINH";
            this.colMAKHAISINH.OptionsColumn.AllowEdit = false;
            this.colMAKHAISINH.OptionsColumn.AllowFocus = false;
            this.colMAKHAISINH.Visible = true;
            this.colMAKHAISINH.VisibleIndex = 0;
            this.colMAKHAISINH.Width = 166;
            // 
            // cboSODINHDANH
            // 
            this.cboSODINHDANH.AutoHeight = false;
            this.cboSODINHDANH.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSODINHDANH.DataSource = this.xpNHANKHAU;
            this.cboSODINHDANH.DisplayMember = "HOTENKHAISINH";
            this.cboSODINHDANH.Name = "cboSODINHDANH";
            this.cboSODINHDANH.NullText = "";
            this.cboSODINHDANH.PopupFormSize = new System.Drawing.Size(400, 400);
            this.cboSODINHDANH.ValueMember = "MAKHAISINH";
            this.cboSODINHDANH.View = this.repositoryItemSearchLookUpEdit1View;
            this.cboSODINHDANH.EditValueChanged += new System.EventHandler(this.cboSODINHDANH_EditValueChanged);
            // 
            // xpNHANKHAU
            // 
            this.xpNHANKHAU.DeleteObjectOnRemove = true;
            this.xpNHANKHAU.ObjectType = typeof(prjQLNK.QLNK.NHANKHAU);
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn2.Caption = "Số định danh";
            this.gridColumn2.FieldName = "MAKHAISINH";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn3.Caption = "Họ tên khai sinh";
            this.gridColumn3.FieldName = "HOTENKHAISINH";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // colSOHOKHAUHT
            // 
            this.colSOHOKHAUHT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSOHOKHAUHT.AppearanceHeader.Options.UseFont = true;
            this.colSOHOKHAUHT.AppearanceHeader.Options.UseTextOptions = true;
            this.colSOHOKHAUHT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOHOKHAUHT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSOHOKHAUHT.Caption = "Số sổ hộ khẩu hiện tại";
            this.colSOHOKHAUHT.FieldName = "SOHOKHAUHT";
            this.colSOHOKHAUHT.Name = "colSOHOKHAUHT";
            this.colSOHOKHAUHT.OptionsColumn.AllowEdit = false;
            this.colSOHOKHAUHT.OptionsColumn.AllowFocus = false;
            this.colSOHOKHAUHT.Visible = true;
            this.colSOHOKHAUHT.VisibleIndex = 1;
            this.colSOHOKHAUHT.Width = 165;
            // 
            // colSOHOKHAUNHAP
            // 
            this.colSOHOKHAUNHAP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSOHOKHAUNHAP.AppearanceHeader.Options.UseFont = true;
            this.colSOHOKHAUNHAP.AppearanceHeader.Options.UseTextOptions = true;
            this.colSOHOKHAUNHAP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOHOKHAUNHAP.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSOHOKHAUNHAP.Caption = "Số sổ hộ khẩu nhập";
            this.colSOHOKHAUNHAP.ColumnEdit = this.cboHoKhau;
            this.colSOHOKHAUNHAP.FieldName = "SOHOKHAUNHAP";
            this.colSOHOKHAUNHAP.Name = "colSOHOKHAUNHAP";
            this.colSOHOKHAUNHAP.OptionsColumn.AllowEdit = false;
            this.colSOHOKHAUNHAP.OptionsColumn.AllowFocus = false;
            this.colSOHOKHAUNHAP.Visible = true;
            this.colSOHOKHAUNHAP.VisibleIndex = 2;
            this.colSOHOKHAUNHAP.Width = 211;
            // 
            // cboHoKhau
            // 
            this.cboHoKhau.AutoHeight = false;
            this.cboHoKhau.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboHoKhau.DataSource = this.xpHOKHAU;
            this.cboHoKhau.DisplayMember = "SOHOKHAU";
            this.cboHoKhau.Name = "cboHoKhau";
            this.cboHoKhau.PopupFormSize = new System.Drawing.Size(300, 300);
            this.cboHoKhau.ValueMember = "SOHOKHAU";
            this.cboHoKhau.View = this.gridView2;
            // 
            // xpHOKHAU
            // 
            this.xpHOKHAU.DeleteObjectOnRemove = true;
            this.xpHOKHAU.ObjectType = typeof(prjQLNK.QLNK.HOKHAU);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn4});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.Caption = "Số hộ khẩu";
            this.gridColumn1.FieldName = "SOHOKHAU";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn4.Caption = "Chủ hộ";
            this.gridColumn4.FieldName = "HOTENCHUHO";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // colQUANHEVOICH
            // 
            this.colQUANHEVOICH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colQUANHEVOICH.AppearanceHeader.Options.UseFont = true;
            this.colQUANHEVOICH.AppearanceHeader.Options.UseTextOptions = true;
            this.colQUANHEVOICH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQUANHEVOICH.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQUANHEVOICH.Caption = "Quan hệ với chủ hộ";
            this.colQUANHEVOICH.FieldName = "QUANHEVOICH";
            this.colQUANHEVOICH.Name = "colQUANHEVOICH";
            this.colQUANHEVOICH.OptionsColumn.AllowEdit = false;
            this.colQUANHEVOICH.OptionsColumn.AllowFocus = false;
            this.colQUANHEVOICH.Visible = true;
            this.colQUANHEVOICH.VisibleIndex = 3;
            this.colQUANHEVOICH.Width = 277;
            // 
            // colNGAYNHAP
            // 
            this.colNGAYNHAP.AppearanceCell.Options.UseTextOptions = true;
            this.colNGAYNHAP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAYNHAP.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNGAYNHAP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNGAYNHAP.AppearanceHeader.Options.UseFont = true;
            this.colNGAYNHAP.AppearanceHeader.Options.UseTextOptions = true;
            this.colNGAYNHAP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAYNHAP.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNGAYNHAP.Caption = "Ngày nhập";
            this.colNGAYNHAP.ColumnEdit = this.repositoryItemDateEdit2;
            this.colNGAYNHAP.FieldName = "NGAYNHAP";
            this.colNGAYNHAP.Name = "colNGAYNHAP";
            this.colNGAYNHAP.OptionsColumn.AllowEdit = false;
            this.colNGAYNHAP.OptionsColumn.AllowFocus = false;
            this.colNGAYNHAP.Visible = true;
            this.colNGAYNHAP.VisibleIndex = 4;
            this.colNGAYNHAP.Width = 154;
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit2.EditFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // cboGT
            // 
            this.cboGT.AutoHeight = false;
            this.cboGT.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboGT.Name = "cboGT";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.EditFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1042, 514);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlGroup3.AppearanceGroup.Options.UseFont = true;
            buttonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions1.Image")));
            buttonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions2.Image")));
            buttonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions3.Image")));
            buttonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions4.Image")));
            this.layoutControlGroup3.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Làm mới", true, buttonImageOptions1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Thêm", true, buttonImageOptions2),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Sửa", true, buttonImageOptions3),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Xoá", true, buttonImageOptions4)});
            this.layoutControlGroup3.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1022, 494);
            this.layoutControlGroup3.Text = "Danh sách nhập - tách khẩu";
            this.layoutControlGroup3.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.layoutControlGroup3_CustomButtonClick);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(998, 451);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // alertControl1
            // 
            this.alertControl1.AutoFormDelay = 3000;
            this.alertControl1.AutoHeight = true;
            this.alertControl1.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.SlideHorizontal;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.InsertGalleryImage("edit", "office2013/edit/edit_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/edit/edit_16x16.png"), 0);
            this.imageCollection1.Images.SetKeyName(0, "edit");
            this.imageCollection1.InsertGalleryImage("delete", "office2013/actions/deletelist_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/deletelist_16x16.png"), 1);
            this.imageCollection1.Images.SetKeyName(1, "delete");
            this.imageCollection1.InsertGalleryImage("info", "images/mail/contact_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/contact_16x16.png"), 2);
            this.imageCollection1.Images.SetKeyName(2, "info");
            // 
            // frmNhapKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 514);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmNhapKhau";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NHẬP KHẨU -TÁCH KHẨU";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpNHAPKHAU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitNHAPKHAU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSODINHDANH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpNHANKHAU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboHoKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpHOKHAU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.Xpo.XPCollection xpNHAPKHAU;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cboGT;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.Xpo.XPCollection xpNHANKHAU;
        private DevExpress.Xpo.UnitOfWork unitNHAPKHAU;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cboSODINHDANH;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHAISINH;
        private DevExpress.XtraGrid.Columns.GridColumn colSOHOKHAUHT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOHOKHAUNHAP;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYNHAP;
        private DevExpress.XtraGrid.Columns.GridColumn colQUANHEVOICH;
        private DevExpress.Xpo.XPCollection xpHOKHAU;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cboHoKhau;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}

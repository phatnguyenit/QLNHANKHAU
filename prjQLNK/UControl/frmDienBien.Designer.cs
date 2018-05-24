namespace prjQLNK
{
    partial class frmDienBien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDienBien));
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions2 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions3 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.xpDIENBIEN = new DevExpress.Xpo.XPCollection(this.components);
            this.unitDIENBIEN = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHAISINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboSODINHDANH = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.xpNHANKHAU = new DevExpress.Xpo.XPCollection(this.components);
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOIDI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYDI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colNOIDEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYDEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLYDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHOIHAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACANBO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYLAP = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.xpDIENBIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitDIENBIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSODINHDANH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpNHANKHAU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
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
            this.gridControl1.DataSource = this.xpDIENBIEN;
            this.gridControl1.Location = new System.Drawing.Point(24, 43);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboGT,
            this.repositoryItemDateEdit1,
            this.cboSODINHDANH,
            this.repositoryItemDateEdit2});
            this.gridControl1.Size = new System.Drawing.Size(994, 447);
            this.gridControl1.TabIndex = 384;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xpDIENBIEN
            // 
            this.xpDIENBIEN.DeleteObjectOnRemove = true;
            this.xpDIENBIEN.ObjectType = typeof(prjQLNK.QLNK.DIENBIEN);
            this.xpDIENBIEN.Session = this.unitDIENBIEN;
            // 
            // unitDIENBIEN
            // 
            this.unitDIENBIEN.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.unitDIENBIEN.TrackPropertiesModifications = false;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colMAKHAISINH,
            this.colNOIDI,
            this.colNGAYDI,
            this.colNOIDEN,
            this.colNGAYDEN,
            this.colLYDO,
            this.colTHOIHAN,
            this.colMACANBO,
            this.colNGAYLAP});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "Nhập thông tin cần tìm ...";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridView1_PopupMenuShowing);
            // 
            // colSTT
            // 
            this.colSTT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSTT.AppearanceHeader.Options.UseFont = true;
            this.colSTT.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.OptionsColumn.ShowInCustomizationForm = false;
            this.colSTT.OptionsColumn.ShowInExpressionEditor = false;
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
            this.colMAKHAISINH.Visible = true;
            this.colMAKHAISINH.VisibleIndex = 0;
            this.colMAKHAISINH.Width = 121;
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
            // colNOIDI
            // 
            this.colNOIDI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNOIDI.AppearanceHeader.Options.UseFont = true;
            this.colNOIDI.AppearanceHeader.Options.UseTextOptions = true;
            this.colNOIDI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNOIDI.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNOIDI.Caption = "Nơi đi";
            this.colNOIDI.FieldName = "NOIDI";
            this.colNOIDI.Name = "colNOIDI";
            this.colNOIDI.Visible = true;
            this.colNOIDI.VisibleIndex = 1;
            this.colNOIDI.Width = 178;
            // 
            // colNGAYDI
            // 
            this.colNGAYDI.AppearanceCell.Options.UseTextOptions = true;
            this.colNGAYDI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAYDI.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNGAYDI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNGAYDI.AppearanceHeader.Options.UseFont = true;
            this.colNGAYDI.AppearanceHeader.Options.UseTextOptions = true;
            this.colNGAYDI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAYDI.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNGAYDI.Caption = "Ngày đi";
            this.colNGAYDI.ColumnEdit = this.repositoryItemDateEdit2;
            this.colNGAYDI.FieldName = "NGAYDI";
            this.colNGAYDI.Name = "colNGAYDI";
            this.colNGAYDI.Visible = true;
            this.colNGAYDI.VisibleIndex = 2;
            this.colNGAYDI.Width = 84;
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
            // colNOIDEN
            // 
            this.colNOIDEN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNOIDEN.AppearanceHeader.Options.UseFont = true;
            this.colNOIDEN.AppearanceHeader.Options.UseTextOptions = true;
            this.colNOIDEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNOIDEN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNOIDEN.Caption = "Nơi đến";
            this.colNOIDEN.FieldName = "NOIDEN";
            this.colNOIDEN.Name = "colNOIDEN";
            this.colNOIDEN.Visible = true;
            this.colNOIDEN.VisibleIndex = 3;
            this.colNOIDEN.Width = 184;
            // 
            // colNGAYDEN
            // 
            this.colNGAYDEN.AppearanceCell.Options.UseTextOptions = true;
            this.colNGAYDEN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAYDEN.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNGAYDEN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNGAYDEN.AppearanceHeader.Options.UseFont = true;
            this.colNGAYDEN.AppearanceHeader.Options.UseTextOptions = true;
            this.colNGAYDEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAYDEN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNGAYDEN.Caption = "Ngày đến";
            this.colNGAYDEN.ColumnEdit = this.repositoryItemDateEdit2;
            this.colNGAYDEN.FieldName = "NGAYDEN";
            this.colNGAYDEN.Name = "colNGAYDEN";
            this.colNGAYDEN.Visible = true;
            this.colNGAYDEN.VisibleIndex = 4;
            this.colNGAYDEN.Width = 80;
            // 
            // colLYDO
            // 
            this.colLYDO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colLYDO.AppearanceHeader.Options.UseFont = true;
            this.colLYDO.AppearanceHeader.Options.UseTextOptions = true;
            this.colLYDO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLYDO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colLYDO.Caption = "Lý do đi/đến";
            this.colLYDO.FieldName = "LYDO";
            this.colLYDO.Name = "colLYDO";
            this.colLYDO.Visible = true;
            this.colLYDO.VisibleIndex = 5;
            this.colLYDO.Width = 144;
            // 
            // colTHOIHAN
            // 
            this.colTHOIHAN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTHOIHAN.AppearanceHeader.Options.UseFont = true;
            this.colTHOIHAN.AppearanceHeader.Options.UseTextOptions = true;
            this.colTHOIHAN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTHOIHAN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTHOIHAN.Caption = "Thời hạn";
            this.colTHOIHAN.FieldName = "THOIHAN";
            this.colTHOIHAN.Name = "colTHOIHAN";
            this.colTHOIHAN.Visible = true;
            this.colTHOIHAN.VisibleIndex = 6;
            this.colTHOIHAN.Width = 87;
            // 
            // colMACANBO
            // 
            this.colMACANBO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMACANBO.AppearanceHeader.Options.UseFont = true;
            this.colMACANBO.AppearanceHeader.Options.UseTextOptions = true;
            this.colMACANBO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMACANBO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMACANBO.FieldName = "MACANBO";
            this.colMACANBO.Name = "colMACANBO";
            this.colMACANBO.OptionsColumn.ShowInCustomizationForm = false;
            this.colMACANBO.OptionsColumn.ShowInExpressionEditor = false;
            // 
            // colNGAYLAP
            // 
            this.colNGAYLAP.AppearanceCell.Options.UseTextOptions = true;
            this.colNGAYLAP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAYLAP.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNGAYLAP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNGAYLAP.AppearanceHeader.Options.UseFont = true;
            this.colNGAYLAP.AppearanceHeader.Options.UseTextOptions = true;
            this.colNGAYLAP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAYLAP.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNGAYLAP.Caption = "Ngày lập";
            this.colNGAYLAP.ColumnEdit = this.repositoryItemDateEdit2;
            this.colNGAYLAP.FieldName = "NGAYLAP";
            this.colNGAYLAP.Name = "colNGAYLAP";
            this.colNGAYLAP.Visible = true;
            this.colNGAYLAP.VisibleIndex = 7;
            this.colNGAYLAP.Width = 95;
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
            this.layoutControlGroup3.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Làm mới", true, buttonImageOptions1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Lưu", true, buttonImageOptions2),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Xoá", true, buttonImageOptions3)});
            this.layoutControlGroup3.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1022, 494);
            this.layoutControlGroup3.Text = "Danh sách diễn biến";
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
            this.imageCollection1.InsertGalleryImage("info", "images/mail/contact_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/contact_16x16.png"), 0);
            this.imageCollection1.Images.SetKeyName(0, "info");
            // 
            // frmDienBien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 514);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmDienBien";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DIỂN BIẾN";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpDIENBIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitDIENBIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSODINHDANH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpNHANKHAU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
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
        private DevExpress.Xpo.XPCollection xpDIENBIEN;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cboGT;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.Xpo.XPCollection xpNHANKHAU;
        private DevExpress.Xpo.UnitOfWork unitDIENBIEN;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cboSODINHDANH;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHAISINH;
        private DevExpress.XtraGrid.Columns.GridColumn colNOIDI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYDI;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colNOIDEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYDEN;
        private DevExpress.XtraGrid.Columns.GridColumn colLYDO;
        private DevExpress.XtraGrid.Columns.GridColumn colTHOIHAN;
        private DevExpress.XtraGrid.Columns.GridColumn colMACANBO;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYLAP;
        private DevExpress.Utils.ImageCollection imageCollection1;
    }
}

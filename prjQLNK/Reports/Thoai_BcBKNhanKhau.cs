using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using prjQLNK.Control;

namespace prjQLNK
{
    public partial class Thoai_BcBKNhanKhau : DevExpress.XtraEditors.XtraForm
    {
        int IDNK_=0;
        public Thoai_BcBKNhanKhau(int IDNK)
        {
            InitializeComponent();
            IDNK_ = IDNK;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if(Bientoancuc.inSua==true)
            {
                SplashScreenManager.ShowDefaultWaitForm("Đang tạo báo cáo", "Vui lòng chờ...");
                frmReport fr = new frmReport();
                BcBKNK re = new BcBKNK(IDNK_, txtNguoiLap.Text, Convert.ToDateTime(dpkNgayLap.EditValue), txtDiaChi.Text);
                fr.Text = "BẢN KHAI NHÂN KHẨU";
                fr.docView.PrintingSystem = re.PrintingSystem;
                re.CreateDocument();
                fr.ShowDialog();
                SplashScreenManager.CloseDefaultWaitForm();
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Thoai_BcHoKhau_Load(object sender, EventArgs e)
        {
            dpkNgayLap.EditValue = DateTime.Today;
            txtNguoiLap.Text = ThongTinDN.Tencanbo;
        }
    }
}
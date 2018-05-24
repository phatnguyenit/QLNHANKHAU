using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Linq;
using prjQLNK.QLNK;

namespace prjQLNK
{
    public partial class BcHoKhau : DevExpress.XtraReports.UI.XtraReport
    {
        public string NguoiLap_ = "...................................................................", DiaChi_ = "........................................";
        public DateTime NgayLap_ = DateTime.Today;

        public DateTime NgayTu, NgayDen;
        public BcHoKhau(string NguoiLap, DateTime NgayLap, string DiaChi)
        {
            InitializeComponent();
            if (NgayTu != DateTime.MinValue && NgayDen != DateTime.MinValue)
            {
                xrDangKy.Visible = true;
                xrDangKy.Text = "Đăng ký từ ngày " + NgayTu.ToString("dd/MM/yyyy") + " đến ngày " + NgayDen.ToString("dd/MM/yyyy");
            }
            if (NguoiLap != "")
                NguoiLap_ = NguoiLap;
            if (DiaChi != "")
                DiaChi_ = DiaChi;
            NgayLap_ = NgayLap;
            xrLabel38.Text = DiaChi_ + ", ngày " + NgayLap_.Day + " tháng " + NgayLap_.Month + " năm " + NgayLap_.Year;
            xrNguoilap.Text = NguoiLap_;
        }

        private void BcHoKhau_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var hokhau_ = (from hk in xpHOKHAU.Cast<HOKHAU>()
                           join nk in xpNHANKHAU.Cast<NHANKHAU>() on hk.SOHOKHAU equals nk.SOHOKHAU
                           select new
                           {
                               SOHOKHAU = hk.SOHOKHAU,
                               HOTENCHUHO = nk.HOTENKHAISINH,
                               DIACHI = nk.DC1 + ", xã " + nk.IDXA1 + ", huyện " + nk.IDHUYEN1 + ", tỉnh " + nk.IDTINH1,
                               NGAYDK = hk.NGAYDK
                           }).GroupBy(o => o.SOHOKHAU).Select(o => new
                           {
                               SOHOKHAU = o.Select(o1 => o1.SOHOKHAU).FirstOrDefault(),
                               HOTENCHUHO = o.Select(o1 => o1.HOTENCHUHO).FirstOrDefault(),
                               NGAYDK = o.Select(o1 => o1.NGAYDK).FirstOrDefault(),
                               DIACHI = o.Select(o1 => o1.DIACHI).FirstOrDefault(),
                           });
            if (NgayTu != DateTime.MinValue && NgayDen != DateTime.MinValue)
                this.DataSource = hokhau_.Where(o => o.NGAYDK >= NgayTu && o.NGAYDK <= NgayDen).ToList();
            else
                this.DataSource = hokhau_.ToList();
        }
    }
}

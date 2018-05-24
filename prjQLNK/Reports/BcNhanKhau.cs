using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Linq;
using DevExpress.Xpo;
using prjQLNK.QLNK;

namespace prjQLNK
{
    public partial class BcNhanKhau : DevExpress.XtraReports.UI.XtraReport
    {
        public string NguoiLap_ = "...................................................................", DiaChi_ = "........................................";
        public DateTime NgayLap_ = DateTime.Today;

        public DateTime NgayTu, NgayDen;
        public BcNhanKhau(string NguoiLap, DateTime NgayLap, string DiaChi)
        {
            InitializeComponent();
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
            var nhankhau_ = (from hk in new XPQuery<HOKHAU>(Session.DefaultSession)
                             join nk in new XPQuery<NHANKHAU>(Session.DefaultSession) on hk.SOHOKHAU equals nk.SOHOKHAU
                             select new
                             {
                                 MAKHAISINH = nk.MAKHAISINH,
                                 HOTENKHAISINH = nk.HOTENKHAISINH,
                                 TENGOIKHAC = nk.TENGOIKHAC,
                                 NGAYSINH = nk.NGAYSINH,
                                 GIOITINH = nk.GIOITINH == 0 ? "Nam" : nk.GIOITINH == 1 ? "Nữ" : "",
                                 DANTOC = nk.DANTOC,
                                 TONGIAO = nk.TONGIAO,
                                 QUOCTICH = nk.QUOCTICH,
                                 SOCMND = nk.SOCMND,
                                 NGAYCAP = nk.NGAYCAP.ToString("dd/MM/yyyy"),
                                 NOICAP = nk.NOICAP,
                                 TRINHDO = nk.TRINHDO,
                                 TDCHUYENMON = nk.TDCHUYENMON,
                                 NGHENGHIEP = nk.NGHENGHIEP,
                                 NOILAMVIEC = nk.NOILAMVIEC,
                                 QUANHE = nk.QUANHE,
                                 BIETTIENGDANTOC = nk.BIETTIENGDANTOC,
                                 TDNGOAINGU = nk.TDNGOAINGU,
                                 SOHOKHAU = nk.SOHOKHAU,

                                 NOISINH = nk.DC1 + ", xã " + nk.IDXA1 + ", huyện " + nk.IDHUYEN1 + ", tỉnh " + nk.IDTINH1,
                                 NGUYENQUAN = nk.DC2 + ", xã " + nk.IDXA2 + ", huyện " + nk.IDHUYEN2 + ", tỉnh " + nk.IDTINH2,
                                 NOITHUONGTRU = nk.DC3 + ", xã " + nk.IDXA3 + ", huyện " + nk.IDHUYEN3 + ", tỉnh " + nk.IDTINH3,
                                 CHOOHIENHAN = nk.DC4 + ", xã " + nk.IDXA4 + ", huyện " + nk.IDHUYEN4 + ", tỉnh " + nk.IDTINH4,
                             }).ToList();
            this.DataSource = nhankhau_.ToList();
        }
    }
}

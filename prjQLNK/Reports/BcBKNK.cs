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
    public partial class BcBKNK : DevExpress.XtraReports.UI.XtraReport
    {
        public string NguoiLap_ = "...................................................................", DiaChi_ = "........................................";
        public DateTime NgayLap_ = DateTime.Today;

        public BcBKNK(int IDNK, string NguoiLap, DateTime NgayLap, string DiaChi)
        {
            InitializeComponent();
            if (NguoiLap != "")
                NguoiLap_ = NguoiLap;
            if (DiaChi != "")
                DiaChi_ = DiaChi;
            NgayLap_ = NgayLap;
            xrLabel38.Text = DiaChi_ + ", ngày " + NgayLap_.Day + " tháng " + NgayLap_.Month + " năm " + NgayLap_.Year;
            xrNguoilap.Text = NguoiLap_;
            ThongTin(IDNK);
            COT19(IDNK);
            COT21(IDNK);
        }
        private void ThongTin(int IDNK)
        {
            var TTNhanKhau = xpNHANKHAU.Cast<NHANKHAU>().Where(o => o.ID == IDNK).ToList();

            xrLabel30.Text = "1. Họ và tên   : " + TTNhanKhau.Select(o => o.HOTENKHAISINH).FirstOrDefault();
            xrLabel7.Text = "2. Họ và tên gọi khác (nếu có): " + TTNhanKhau.Select(o => o.TENGOIKHAC).FirstOrDefault();
            xrLabel8.Text = "3. Ngày, tháng, năm sinh: " + TTNhanKhau.Select(o => o.NGAYSINH).FirstOrDefault().ToString("dd/MM/yyyy");
            xrLabel9.Text = TTNhanKhau.Select(o => o.GIOITINH).FirstOrDefault() == 0 ? "4. Giới tính: Nam" : TTNhanKhau.Select(o => o.GIOITINH).FirstOrDefault() == 1 ? "4. Giới tính: Nữ" : "4. Giới tính:";
            xrLabel10.Text = "5. Nơi sinh: " + TTNhanKhau.Select(o => o.DC1).FirstOrDefault() + ", phường " + TTNhanKhau.Select(o => o.IDXA1).FirstOrDefault() + ", huyện " + TTNhanKhau.Select(o => o.IDHUYEN1).FirstOrDefault() + ", tỉnh " + TTNhanKhau.Select(o => o.IDTINH1).FirstOrDefault();
            xrLabel11.Text = "6. Nguyên quán: " + TTNhanKhau.Select(o => o.DC2).FirstOrDefault() + ", phường " + TTNhanKhau.Select(o => o.IDXA2).FirstOrDefault() + ", huyện " + TTNhanKhau.Select(o => o.IDHUYEN2).FirstOrDefault() + ", tỉnh " + TTNhanKhau.Select(o => o.IDTINH2).FirstOrDefault();
            xrLabel12.Text = "7. Dân tộc: " + TTNhanKhau.Select(o => o.DANTOC).FirstOrDefault();
            xrLabel13.Text = "8. Tôn giáo: " + TTNhanKhau.Select(o => o.TONGIAO).FirstOrDefault();
            xrLabel14.Text = "9. Quốc tịch: " + TTNhanKhau.Select(o => o.QUOCTICH).FirstOrDefault();
            xrLabel20.Text = "10. CMND số: " + TTNhanKhau.Select(o => o.SOCMND).FirstOrDefault();
            xrLabel19.Text = "11. Hộ chiếu số: " + TTNhanKhau.Select(o => o.SOHOCHIEU).FirstOrDefault();
            xrLabel18.Text = "12. Nơi thường trú: " + TTNhanKhau.Select(o => o.DC3).FirstOrDefault() + ", phường " + TTNhanKhau.Select(o => o.IDXA3).FirstOrDefault() + ", huyện " + TTNhanKhau.Select(o => o.IDHUYEN3).FirstOrDefault() + ", tỉnh " + TTNhanKhau.Select(o => o.IDTINH3).FirstOrDefault();
            xrLabel16.Text = "13. Chổ ở hiện nay: " + TTNhanKhau.Select(o => o.DC4).FirstOrDefault() + ", phường " + TTNhanKhau.Select(o => o.IDXA4).FirstOrDefault() + ", huyện " + TTNhanKhau.Select(o => o.IDHUYEN4).FirstOrDefault() + ", tỉnh " + TTNhanKhau.Select(o => o.IDTINH4).FirstOrDefault();
            xrLabel32.Text = "14. Trình độ học vấn   : " + TTNhanKhau.Select(o => o.TRINHDO).FirstOrDefault();
            xrLabel33.Text = "15. Trình độ chuyên môn    : " + TTNhanKhau.Select(o => o.TDCHUYENMON).FirstOrDefault();
            xrLabel15.Text = "16. Biết tiếng dân tộc: " + TTNhanKhau.Select(o => o.BIETTIENGDANTOC).FirstOrDefault();
            xrLabel21.Text = "17. Trình độ ngoại ngữ: " + TTNhanKhau.Select(o => o.TDNGOAINGU).FirstOrDefault();
            xrLabel17.Text = "18. Nghề nghiệp, nơi làm việc: " + TTNhanKhau.Select(o => o.NGHENGHIEP).FirstOrDefault() + " - Nơi làm việc: " + TTNhanKhau.Select(o => o.NOILAMVIEC).FirstOrDefault();
        }

        private void COT19(int IDNK)
        {
            var QuaTrinh = from nk in xpNHANKHAU.Cast<NHANKHAU>().Where(o => o.ID == IDNK)
                           join qt in xpQUATRINH.Cast<QUATRINH>() on nk.MAKHAISINH equals qt.MAKHAISINH
                           select new
                           {
                               NGAYTU_DEN = qt.TUTHANGNAM.ToString("dd/MM/yyyy") + " - " + qt.DENTHANGNAM.ToString("dd/MM/yyyy"),
                               CHOO = qt.CHOO,
                               NGHE_NOILV = qt.NGHENGHIEP + ". Nơi làm việc: " + qt.NOILAMVIEC,
                           };
            DetailReport.DataSource = QuaTrinh.ToList();
        }
        private void COT21(int IDNK)
        {
            var QuanHe_ = from nk in xpNHANKHAU.Cast<NHANKHAU>().Where(o => o.ID == IDNK)
                          join qh in xpQUANHE.Cast<QUANHE>() on nk.MAKHAISINH equals qh.MAKHAISINH
                          select new
                          {
                              HOTEN = qh.HOTEN,
                              NGAYSINH = qh.NGAYSINH.ToString("dd/MM/yyyy"),
                              GIOITINH = qh.GIOITINH == 0 ? "Nam" : qh.GIOITINH == 1 ? "Nữ" : "",
                              QUANHE1 = qh.QUANHE1,
                              NGHENGHIEP = qh.NGHENGHIEP,
                              CHOO = qh.CHOO,
                          };
            DetailReport2.DataSource = QuanHe_.ToList();
        }
    }
}

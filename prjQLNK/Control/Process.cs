using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using prjQLNK.Model;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjQLNK.Control
{
    class Process : DataProvider
    {
        DataProvider provider = new DataProvider();
        public static string Macanbo = "";

        public Process()
        {
            Connect_process();
        }

        public void Connect_process()
        {
            provider.Connect_provider();
        }

        public void Disconnect_process()
        {
            provider.Disconnect_provider();
        }

        public DataTable LoadSHK()
        {
            return provider.Load("SP_LOADHOKHAU");
        }

        public DataTable LoadKhaiSinh()
        {
            return provider.Load("SP_LOADKHAISINH");
        }

        public DataTable LoadQG()
        {
            return provider.Load("SP_LOADQG");
        }

        public DataTable LoadDanToc()
        {
            return provider.Load("SP_LOADDANTOC");
        }

        public DataTable LoadTonGiao()
        {
            return provider.Load("SP_LOADTONGIAO");
        }

        public DataTable LoadCanBo()
        {
            return provider.Load("SP_LOADLUOICANBO");
        }

        //public DataTable LoadLuoi(string TenBang, string DieuKien)
        //{
        //    return provider.LayDuLieuCoDK("SP_LOADLUOI", TenBang, DieuKien);
        //}

        public DataTable LoadLuoiQH(string TenBang, string DieuKien)
        {
            return provider.LayDuLieuCoDK("SP_LOADQUANHE", TenBang, DieuKien);
        }

        public DataTable LoadTTKS(string TenBang, string DieuKien)
        {
            return provider.LayDuLieuCoDK("SP_LOADTTKHAISINH", TenBang, DieuKien);
        }

        public DataTable LoadNhanKhau()
        {
            return provider.Load("SP_LOADNHANKHAU");
        }

        public DataTable LayDuLieuCoDK(string TenBang, string DieuKien)
        {
            return provider.LayDuLieuCoDK("SP_LAYDULIEUCODK", TenBang, DieuKien);
        }

        public void Themhokhau(int sohokhau, string hotenchuho, string diachi, DateTime ngaydk, string ghichu, string canbo)
        {
            provider.Themhokhau("SP_THEMHOKHAU", sohokhau, hotenchuho, diachi, ngaydk, ghichu, canbo);
        }

        public void Themnhankhau(int sohokhau, string makhaisinh, string hotenkhaisinh, string tengoikhac, bool gioitinh, DateTime ngaysinh, string noisinh, string quequan, string choohiennay, string dantoc, string tongiao, string socmnd, DateTime ngaycap, string noicapcmnd, string hinhanh, string noidkhktt, string trinhdohocvan, string nghenghiep, string dauvet, string ghichu, string canbohuongdan, string nguoikhai, DateTime ngaykhai, string quoctich)
        {
            provider.Themnhankhau("SP_THEMNHANKHAU", sohokhau, makhaisinh, hotenkhaisinh, tengoikhac, gioitinh, ngaysinh, noisinh, quequan, choohiennay, dantoc, tongiao, socmnd, ngaycap, noicapcmnd, hinhanh, noidkhktt, trinhdohocvan, nghenghiep, dauvet, ghichu, canbohuongdan, nguoikhai, ngaykhai, quoctich);
        }

        public void Themnhankhau1(int sohokhau, string makhaisinh, string hotenkhaisinh, string tengoikhac, bool gioitinh, DateTime ngaysinh, string noisinh, string quequan, string choohiennay, string dantoc, string tongiao, string hinhanh, string noidkhktt, string trinhdohocvan, string nghenghiep, string dauvet, string ghichu, string canbohuongdan, string nguoikhai, DateTime ngaykhai, string quoctich)
        {
            provider.Themnhankhau1("SP_THEMNHANKHAU1", sohokhau, makhaisinh, hotenkhaisinh, tengoikhac, gioitinh, ngaysinh, noisinh, quequan, choohiennay, dantoc, tongiao, hinhanh, noidkhktt, trinhdohocvan, nghenghiep, dauvet, ghichu, canbohuongdan, nguoikhai, ngaykhai, quoctich);
        }

        public void Themcanbo(string macanbo, string tencanbo, int gioitinh, DateTime ngaysinh, string chucvu, string diachi, string sdt, string email, string quyenhan)
        {
            provider.Themcanbo1("SP_THEMCANBO", macanbo, tencanbo, gioitinh, ngaysinh, chucvu, diachi, sdt, email, quyenhan);
        }

        public void Themnguoidung(string taikhoan, string matkhau, string macanbo, string matkhaucap2)
        {
            provider.Themnguoidung1("SP_THEMNGUOIDUNG", taikhoan, matkhau, matkhaucap2, macanbo);
        }

        public void Themthongtinkhaisinh(int sohokhau, string makhaisinh, string hotenkhaisinh, bool gioitinh, DateTime ngaysinh, string noisinh, string dantoc, string quoctich, string noidkkhaisinh, string quanhekhaisinh, string nguoikhaisinh, string canbohuongdan, string ghichu, DateTime ngaydkkhaisinh, string hinhanh)
        {
            provider.Themthongtinkhaisinh("SP_THEMTHONGTINKHAISINH", sohokhau, makhaisinh, hotenkhaisinh, gioitinh, ngaysinh, noisinh, dantoc, quoctich, noidkkhaisinh, quanhekhaisinh, nguoikhaisinh, canbohuongdan, ghichu, ngaydkkhaisinh, hinhanh);
        }

        public void Themquatrinh(string makhaisinh, DateTime tuthangnam, DateTime denthangnam, string choo, string nghenghiep, string noilamviec, string ghichu)
        {
            provider.Themquatrinh("SP_THEMQUATRINH", makhaisinh, tuthangnam, denthangnam, choo, nghenghiep, noilamviec, ghichu);
        }

        public void Themquanhe(string makhaisinh, string hoten, string gioitinh, DateTime ngaysinh, string quanhe, string nghenghiep, string choo)
        {
            provider.Themquanhe("SP_THEMQUANHE", makhaisinh, hoten, gioitinh, ngaysinh, quanhe, nghenghiep, choo);
        }

        public void Themdienbien(string makhaisinh, string noidi, DateTime ngaydi, string noiden, DateTime ngayden, string lydo, string thoihan, string macanbo, DateTime ngaylap)
        {
            provider.Themdienbien1("SP_THEMDIENBIEN", makhaisinh, noidi, ngaydi, noiden, ngayden, lydo, thoihan, macanbo, ngaylap);
        }

        public void Themtamvang(string makhaisinh, DateTime ngayvang, DateTime ngayketthuc, string noiden, string lydo, DateTime ngaylap, string macanbo, string ghichu, string nguoikhaibao)
        {
            provider.Themtamvang1("SP_THEMTAMVANG", makhaisinh, ngayvang, ngayketthuc, noiden, lydo, ngaylap, macanbo, ghichu, nguoikhaibao);
        }

        public void Thembaotu(string makhaisinh, DateTime ngaymat, string lydo, string ghichu, string macanbo, string nguoikhai, DateTime ngaykhai)
        {
            provider.Thembaotu1("SP_THEMBAOTU", makhaisinh, ngaymat, lydo, ghichu, macanbo, nguoikhai, ngaykhai);
        }

        public void Themquanhe1(string makhaisinh, string hoten, DateTime ngaysinh, string gioitinh, string quanhe, string dantoc, string quoctich, string choo, string nghenghiep)
        {
            provider.Themquanhe1("SP_THEMQUANHEKHAISINH", makhaisinh, hoten, ngaysinh, gioitinh, quanhe, dantoc, quoctich, choo, nghenghiep);
        }

        public void Themkhenthuong(string makhaisinh, DateTime ngaythang, string coquan, string sukien, string hinhthuc, DateTime ngayluu, string ghichu)
        {
            provider.Themkhenthuong("SP_THEMKHENTHUONG", makhaisinh, ngaythang, coquan, sukien, hinhthuc, ngayluu, ghichu);
        }

        public void Themtienan(string makhaisinh, DateTime ngaythang, string tienan, string hinhthuc, string mucdo, string thoigian, string coquanxuly, DateTime ngayluu, string ghichu)
        {
            provider.Themtienan("SP_THEMTIENAN", makhaisinh, ngaythang, ngayluu, tienan, hinhthuc, mucdo, thoigian, coquanxuly, ghichu);
        }
        
        public void Xoa(string TenBang, string DieuKien)
        {
            provider.Xoa("SP_XOA", TenBang, DieuKien);
        }

        public bool CapNhatDuLieuBang1(string TenBang, string DieuKien, DataTable tbl)
        {
            return provider.CapNhatDuLieuBang2("SP_LAYDULIEUCODK", TenBang, DieuKien, tbl);
        }
    }

    class Quatrinh
    {
        DateTime tuthangnam, denthangnam;
        public static bool Chon = false;
        public static string STT="";

        public DateTime Tuthangnam
        {
            get { return tuthangnam; }
            set { tuthangnam = value; }
        }

        public DateTime Denthangnam
        {
            get { return denthangnam; }
            set { denthangnam = value; }
        }
        string choo, nghenghiep, noilamviec, ghichu, makhaisinh;

        public string Makhaisinh
        {
            get { return makhaisinh; }
            set { makhaisinh = value; }
        }

        public string Choo
        {
            get { return choo; }
            set { choo = value; }
        }

        public string Nghenghiep
        {
            get { return nghenghiep; }
            set { nghenghiep = value; }
        }

        public string Noilamviec
        {
            get { return noilamviec; }
            set { noilamviec = value; }
        }

        public string Ghichu
        {
            get { return ghichu; }
            set { ghichu = value; }
        }
    }

    class Tamvang
    {
        DateTime ngayvang, ngayketthuc, ngaylap;
        public static bool Chon = false;
        public static string STT = "";

        public DateTime Ngayketthuc
        {
            get { return ngayketthuc; }
            set { ngayketthuc = value; }
        }

        public DateTime Ngayvang
        {
            get { return ngayvang; }
            set { ngayvang = value; }
        }

        public DateTime Ngaylap
        {
            get { return ngaylap; }
            set { ngaylap = value; }
        }

        string makhaisinh, lydo, noiden, nguoikhaibao, macanbo, ghichu;

        public string Makhaisinh
        {
            get { return makhaisinh; }
            set { makhaisinh = value; }
        }

        public string Lydo
        {
            get { return lydo; }
            set { lydo = value; }
        }

        public string Noiden
        {
            get { return noiden; }
            set { noiden = value; }
        }

        public string Nguoikhaibao
        {
            get { return nguoikhaibao; }
            set { nguoikhaibao = value; }
        }

        public string Macanbo
        {
            get { return macanbo; }
            set { macanbo = value; }
        }

        public string Ghichu
        {
            get { return ghichu; }
            set { ghichu = value; }
        }
    }

    class Dienbien
    {
        DateTime ngaydi, ngayden, ngaylap;
        public static bool Chon = false;
        public static string STT = "";

        public DateTime Ngaydi
        {
            get { return ngaydi; }
            set { ngaydi = value; }
        }

        public DateTime Ngayden
        {
            get { return ngayden; }
            set { ngayden = value; }
        }

        public DateTime Ngaylap
        {
            get { return ngaylap; }
            set { ngaylap = value; }
        }
        string makhaisinh, noidi, noiden, lydo, thoihan, macanbo;

        public string Makhaisinh
        {
            get { return makhaisinh; }
            set { makhaisinh = value; }
        }

        public string Noidi
        {
            get { return noidi; }
            set { noidi = value; }
        }

        public string Noiden
        {
            get { return noiden; }
            set { noiden = value; }
        }

        public string Lydo
        {
            get { return lydo; }
            set { lydo = value; }
        }

        public string Thoihan
        {
            get { return thoihan; }
            set { thoihan = value; }
        }

        public string Macanbo
        {
            get { return macanbo; }
            set { macanbo = value; }
        }
    }

    class ThongTinDN
    {
        public static string Taikhoan = "";
        public static string Matkhau = "";
        public static string Macanbo = "";
        public static string Tencanbo = "";
        public static int Quyenhan;
        public static string QuyenHan = "Người dùng: ";
        public static bool Truycap = false;
    }

    class MKSNguoiMat
    {
        public static string MaKhaiSinh = "";
    }

    class Canbo
    {
        string macanbo, tencanbo, chucvu, diachi, sdt, email, quyenhan;

        public string Macanbo
        {
            get { return macanbo; }
            set { macanbo = value; }
        }

        public string Tencanbo
        {
            get { return tencanbo; }
            set { tencanbo = value; }
        }

        public string Chucvu
        {
            get { return chucvu; }
            set { chucvu = value; }
        }

        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Quyenhan
        {
            get { return quyenhan; }
            set { quyenhan = value; }
        }
        int gioitinh;

        public int Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        DateTime ngaysinh;

        public DateTime Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
    }

    class Nguoidung
    {
        public static string taikhoan, matkhau, matkhaucap2, macanbo;

        public string Matkhaucap2
        {
            get { return matkhaucap2; }
            set { matkhaucap2 = value; }
        }       

        public string Taikhoan
        {
            get { return taikhoan; }
            set { taikhoan = value; }
        }

        public string Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }

        public string Macanbo
        {
            get { return macanbo; }
            set { macanbo = value; }
        }
    }

    class Hokhau
    {
        int sohokhau;
        DateTime ngaydk;

        public DateTime Ngaydk
        {
            get { return ngaydk; }
            set { ngaydk = value; }
        }
        public int Sohokhau
        {
            get { return sohokhau; }
            set { sohokhau = value; }
        }
        string hotenchuho, diachi, ghichu, canbo;

        public string Canbo
        {
            get { return canbo; }
            set { canbo = value; }
        }

        public string Ghichu
        {
            get { return ghichu; }
            set { ghichu = value; }
        }

        public string Hotenchuho
        {
            get { return hotenchuho; }
            set { hotenchuho = value; }
        }

        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
    }

    class Nhankhau
    {
        bool gioitinh;

        public bool Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }

        DateTime ngaysinh, ngaykhai, ngaycapcmnd, ngaydkkhaisinh;

        public DateTime Ngaydkkhaisinh
        {
            get { return ngaydkkhaisinh; }
            set { ngaydkkhaisinh = value; }
        }

        public DateTime Ngaycapcmnd
        {
            get { return ngaycapcmnd; }
            set { ngaycapcmnd = value; }
        }

        public DateTime Ngaykhai
        {
            get { return ngaykhai; }
            set { ngaykhai = value; }
        }

        public DateTime Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }

        string makhaisinh;

        public string Makhaisinh
        {
            get { return makhaisinh; }
            set { makhaisinh = value; }
        }

        int sohokhau;

        public int Sohokhau
        {
            get { return sohokhau; }
            set { sohokhau = value; }
        }

        string quanhekhaisinh, hinhanh, noidkkhaisinh, nguoikhaisinh, quoctich, hotenkhaisinh, tengoikhac, noisinh, quequan, choohiennay, dantoc, tongiao, socmnd, noicapcmnd, noidkhktt, trinhdohocvan, nghenghiep, dauvet, ghichu, canbohuongdan, nguoikhai;

        public string Hinhanh
        {
            get { return hinhanh; }
            set { hinhanh = value; }
        }

        public string Quanhekhaisinh
        {
            get { return quanhekhaisinh; }
            set { quanhekhaisinh = value; }
        }

        public string Nguoikhaisinh
        {
            get { return nguoikhaisinh; }
            set { nguoikhaisinh = value; }
        }

        public string Noidkkhaisinh
        {
            get { return noidkkhaisinh; }
            set { noidkkhaisinh = value; }
        }

        public string Quoctich
        {
            get { return quoctich; }
            set { quoctich = value; }
        }

        public string Hotenkhaisinh
        {
            get { return hotenkhaisinh; }
            set { hotenkhaisinh = value; }
        }

        public string Tengoikhac
        {
            get { return tengoikhac; }
            set { tengoikhac = value; }
        }

        public string Noisinh
        {
            get { return noisinh; }
            set { noisinh = value; }
        }

        public string Quequan
        {
            get { return quequan; }
            set { quequan = value; }
        }

        public string Choohiennay
        {
            get { return choohiennay; }
            set { choohiennay = value; }
        }

        public string Dantoc
        {
            get { return dantoc; }
            set { dantoc = value; }
        }

        public string Tongiao
        {
            get { return tongiao; }
            set { tongiao = value; }
        }

        public string Socmnd
        {
            get { return socmnd; }
            set { socmnd = value; }
        }

        public string Noicapcmnd
        {
            get { return noicapcmnd; }
            set { noicapcmnd = value; }
        }

        public string Noidkhktt
        {
            get { return noidkhktt; }
            set { noidkhktt = value; }
        }

        public string Trinhdohocvan
        {
            get { return trinhdohocvan; }
            set { trinhdohocvan = value; }
        }

        public string Nghenghiep
        {
            get { return nghenghiep; }
            set { nghenghiep = value; }
        }

        public string Dauvet
        {
            get { return dauvet; }
            set { dauvet = value; }
        }

        public string Ghichu
        {
            get { return ghichu; }
            set { ghichu = value; }
        }

        public string Canbohuongdan
        {
            get { return canbohuongdan; }
            set { canbohuongdan = value; }
        }

        public string Nguoikhai
        {
            get { return nguoikhai; }
            set { nguoikhai = value; }
        }
    }

    class Quanhe
    {
        DateTime ngaysinh;
        public static bool Chon = false;
        public static string STT = "";

        public DateTime Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }

        string hoten, quanhe, nghenghiep, choo, makhaisinh, gioitinh, dantoc, quoctich;

        public string Quoctich
        {
            get { return quoctich; }
            set { quoctich = value; }
        }

        public string Dantoc
        {
            get { return dantoc; }
            set { dantoc = value; }
        }

        public string Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }

        public string Makhaisinh
        {
            get { return makhaisinh; }
            set { makhaisinh = value; }
        }

        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }

        public string Quanhe1
        {
            get { return quanhe; }
            set { quanhe = value; }
        }

        public string Nghenghiep
        {
            get { return nghenghiep; }
            set { nghenghiep = value; }
        }

        public string Choo
        {
            get { return choo; }
            set { choo = value; }
        }
    }

    class Khenthuong
    {
        DateTime ngaythang, ngayluu;
        public static bool Chon = false;
        public static string STT = "";

        public DateTime Ngaythang
        {
            get { return ngaythang; }
            set { ngaythang = value; }
        }

        public DateTime Ngayluu
        {
            get { return ngayluu; }
            set { ngayluu = value; }
        }

        string coquan, sukien, hinhthuc, ghichu, makhaisinh;

        public string Makhaisinh
        {
            get { return makhaisinh; }
            set { makhaisinh = value; }
        }

        public string Coquan
        {
            get { return coquan; }
            set { coquan = value; }
        }

        public string Sukien
        {
            get { return sukien; }
            set { sukien = value; }
        }

        public string Hinhthuc
        {
            get { return hinhthuc; }
            set { hinhthuc = value; }
        }

        public string Ghichu
        {
            get { return ghichu; }
            set { ghichu = value; }
        }
    }

    class Tienan
    {
        DateTime ngaythang, ngayluu;
        public static bool Chon = false;
        public static string STT = "";

        public DateTime Ngaythang
        {
            get { return ngaythang; }
            set { ngaythang = value; }
        }

        public DateTime Ngayluu
        {
            get { return ngayluu; }
            set { ngayluu = value; }
        }

        string makhaisinh, tienan, hinhthuc, mucdo, thoigian, coquanxuly, ghichu;

        public string Tienan1
        {
            get { return tienan; }
            set { tienan = value; }
        }

        public string Makhaisinh
        {
            get { return makhaisinh; }
            set { makhaisinh = value; }
        }

        public string Hinhthuc
        {
            get { return hinhthuc; }
            set { hinhthuc = value; }
        }

        public string Mucdo
        {
            get { return mucdo; }
            set { mucdo = value; }
        }

        public string Thoigian
        {
            get { return thoigian; }
            set { thoigian = value; }
        }

        public string Coquanxuly
        {
            get { return coquanxuly; }
            set { coquanxuly = value; }
        }

        public string Ghichu
        {
            get { return ghichu; }
            set { ghichu = value; }
        }
    }


    class NgayThang
    {
        public static int ngay = DateTime.Now.Day;
        public static int thang = DateTime.Now.Month;
        public static int nam = DateTime.Now.Year;
        public static string Homnay = ngay + "/" + thang.ToString() + "/" + nam.ToString();
    }

    class BaoTu
    {
        string makhaisinh, lydo, nguoikhai, ghichu, macanbo;

        public string Makhaisinh
        {
            get { return makhaisinh; }
            set { makhaisinh = value; }
        }

        public string Lydo
        {
            get { return lydo; }
            set { lydo = value; }
        }

        public string Nguoikhai
        {
            get { return nguoikhai; }
            set { nguoikhai = value; }
        }

        public string Ghichu
        {
            get { return ghichu; }
            set { ghichu = value; }
        }

        public string Macanbo
        {
            get { return macanbo; }
            set { macanbo = value; }
        }
        DateTime ngaymat, ngaykhai;

        public DateTime Ngaymat
        {
            get { return ngaymat; }
            set { ngaymat = value; }
        }

        public DateTime Ngaykhai
        {
            get { return ngaykhai; }
            set { ngaykhai = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace prjQLNK.Model
{
    class DataProvider
    {
        SqlConnection cn;
        SqlDataAdapter da;
        SqlCommand cmd;

        public static string connecstring;

        public string Connecstring
        {
            get { return connecstring; }
            set { connecstring = value; }
        }

        public void Connect_provider()
        {
            try
            {
                cn = new SqlConnection(Connecstring);
                cn.Open();
            }
            catch (Exception sqlex)
            {
                throw sqlex;
            }
        }

        public void Disconnect_provider()
        {
            cn.Close();
            cn.Dispose();
        }

        public DataTable Load(string strStore)
        {
            try
            {
                cmd = new SqlCommand(strStore, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception sqlex)
            {
                throw sqlex;
            }
        }
                
        public void Themhokhau(string strStore, int sohokhau, string hotenchuho, string diachi, DateTime ngaydk, string ghichu, string canbo)
        {
            try
            {
                cmd = new SqlCommand(strStore, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@SOHOKHAU", SqlDbType.Int).Value = sohokhau;
                cmd.Parameters.Add("@HOTENCHUHO", SqlDbType.NVarChar).Value = hotenchuho;
                cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = diachi;
                cmd.Parameters.Add("@NGAYDK", SqlDbType.DateTime).Value = ngaydk;
                cmd.Parameters.Add("@GHICHU", SqlDbType.NVarChar).Value = ghichu;
                cmd.Parameters.Add("@MACANBO", SqlDbType.NVarChar).Value = canbo;
                int n = cmd.ExecuteNonQuery();
            }
            catch (Exception sqlex)
            {
                throw sqlex;
            }
        }

        public DataTable LayDuLieuCoDK(string strStore, string TenBang, string DieuKien)
        {
            try
            {
                cmd = new SqlCommand(strStore, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TENBANG", SqlDbType.NVarChar).Value = TenBang;
                cmd.Parameters.Add("@DIEUKIEN", SqlDbType.NVarChar).Value = DieuKien;
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public void Xoa(string strStore, string TenBang, string DieuKien)
        {
            try
            {
                cmd = new SqlCommand(strStore, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TENBANG", SqlDbType.NVarChar).Value = TenBang;
                cmd.Parameters.Add("@DIEUKIEN", SqlDbType.NVarChar).Value = DieuKien;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Themnhankhau(string strStore, int sohokhau, string makhaisinh, string hotenkhaisinh, string tengoikhac, bool gioitinh, DateTime ngaysinh, string noisinh, string quequan, string choohiennay, string dantoc, string tongiao, string socmnd, DateTime ngaycap, string noicapcmnd, string hinhanh, string noidkhktt, string trinhdohocvan, string nghenghiep, string dauvet, string ghichu, string canbohuongdan, string nguoikhai, DateTime ngaykhai, string quoctich)
        {
            try
            {     
                cmd = new SqlCommand(strStore, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MAKHAISINH", SqlDbType.VarChar).Value = makhaisinh;
                cmd.Parameters.Add("@HOTENKHAISINH", SqlDbType.NVarChar).Value = hotenkhaisinh;
                cmd.Parameters.Add("@TENGOIKHAC", SqlDbType.NVarChar).Value = tengoikhac;
                cmd.Parameters.Add("@GIOITINH", SqlDbType.Bit).Value = gioitinh;
                cmd.Parameters.Add("@NGAYSINH", SqlDbType.DateTime).Value = ngaysinh;
                cmd.Parameters.Add("@NOISINH", SqlDbType.NVarChar).Value = noisinh;
                cmd.Parameters.Add("@QUEQUAN", SqlDbType.NVarChar).Value = quequan;
                cmd.Parameters.Add("@CHOOHIENNAY", SqlDbType.NVarChar).Value = choohiennay;
                cmd.Parameters.Add("@DANTOC", SqlDbType.NVarChar).Value = dantoc;
                cmd.Parameters.Add("@TONGIAO", SqlDbType.NVarChar).Value = tongiao;
                cmd.Parameters.Add("@SOCMND", SqlDbType.NVarChar).Value = socmnd;
                cmd.Parameters.Add("@NGAYCAP", SqlDbType.DateTime).Value = ngaycap;
                cmd.Parameters.Add("@NOICAP", SqlDbType.NVarChar).Value = noicapcmnd;
                cmd.Parameters.Add("@HINHANH", SqlDbType.NVarChar).Value = hinhanh;
                cmd.Parameters.Add("@NOIDKHKTT", SqlDbType.NVarChar).Value = noidkhktt;
                cmd.Parameters.Add("@TRINHDO", SqlDbType.NVarChar).Value = trinhdohocvan;
                cmd.Parameters.Add("@NGHENGHIEP", SqlDbType.NVarChar).Value = nghenghiep;
                cmd.Parameters.Add("@DAUVET", SqlDbType.NVarChar).Value = dauvet;
                cmd.Parameters.Add("@NGUOIKHAI", SqlDbType.NVarChar).Value = nguoikhai;
                cmd.Parameters.Add("@NGAYKHAI", SqlDbType.DateTime).Value = ngaykhai;
                cmd.Parameters.Add("@MACANBO", SqlDbType.VarChar).Value = canbohuongdan;
                cmd.Parameters.Add("@SOHOKHAU", SqlDbType.Int).Value = sohokhau;
                cmd.Parameters.Add("@GHICHU", SqlDbType.NVarChar).Value = ghichu;
                cmd.Parameters.Add("@QUOCTICH", SqlDbType.NVarChar).Value = quoctich;
                cmd.ExecuteNonQuery();
            }
            catch (Exception sqlex)
            {
                throw sqlex;
            }
        }

        public void Themnhankhau1(string strStore, int sohokhau, string makhaisinh, string hotenkhaisinh, string tengoikhac, bool gioitinh, DateTime ngaysinh, string noisinh, string quequan, string choohiennay, string dantoc, string tongiao, string hinhanh, string noidkhktt, string trinhdohocvan, string nghenghiep, string dauvet, string ghichu, string canbohuongdan, string nguoikhai, DateTime ngaykhai, string quoctich)
        {
            try
            {
                cmd = new SqlCommand(strStore, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MAKHAISINH", SqlDbType.VarChar).Value = makhaisinh;
                cmd.Parameters.Add("@HOTENKHAISINH", SqlDbType.NVarChar).Value = hotenkhaisinh;
                cmd.Parameters.Add("@TENGOIKHAC", SqlDbType.NVarChar).Value = tengoikhac;
                cmd.Parameters.Add("@GIOITINH", SqlDbType.Bit).Value = gioitinh;
                cmd.Parameters.Add("@NGAYSINH", SqlDbType.DateTime).Value = ngaysinh;
                cmd.Parameters.Add("@NOISINH", SqlDbType.NVarChar).Value = noisinh;
                cmd.Parameters.Add("@QUEQUAN", SqlDbType.NVarChar).Value = quequan;
                cmd.Parameters.Add("@CHOOHIENNAY", SqlDbType.NVarChar).Value = choohiennay;
                cmd.Parameters.Add("@DANTOC", SqlDbType.NVarChar).Value = dantoc;
                cmd.Parameters.Add("@TONGIAO", SqlDbType.NVarChar).Value = tongiao;            
                cmd.Parameters.Add("@HINHANH", SqlDbType.NVarChar).Value = hinhanh;
                cmd.Parameters.Add("@NOIDKHKTT", SqlDbType.NVarChar).Value = noidkhktt;
                cmd.Parameters.Add("@TRINHDO", SqlDbType.NVarChar).Value = trinhdohocvan;
                cmd.Parameters.Add("@NGHENGHIEP", SqlDbType.NVarChar).Value = nghenghiep;
                cmd.Parameters.Add("@DAUVET", SqlDbType.NVarChar).Value = dauvet;
                cmd.Parameters.Add("@NGUOIKHAI", SqlDbType.NVarChar).Value = nguoikhai;
                cmd.Parameters.Add("@NGAYKHAI", SqlDbType.DateTime).Value = ngaykhai;
                cmd.Parameters.Add("@MACANBO", SqlDbType.VarChar).Value = canbohuongdan;
                cmd.Parameters.Add("@SOHOKHAU", SqlDbType.Int).Value = sohokhau;
                cmd.Parameters.Add("@GHICHU", SqlDbType.NVarChar).Value = ghichu;
                cmd.Parameters.Add("@QUOCTICH", SqlDbType.NVarChar).Value = quoctich;
                cmd.ExecuteNonQuery();
            }
            catch (Exception sqlex)
            {
                throw sqlex;
            }
        }

        public void Themcanbo1(string strStore, string macanbo, string tencanbo, int gioitinh, DateTime ngaysinh, string chucvu, string diachi, string sdt, string email, string quyenhan)
        {
            try
            {
                cmd = new SqlCommand(strStore, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MACANBO", SqlDbType.VarChar).Value = macanbo;
                cmd.Parameters.Add("@TENCANBO", SqlDbType.NVarChar).Value = tencanbo;
                cmd.Parameters.Add("@GIOITINH", SqlDbType.Int).Value = gioitinh;
                cmd.Parameters.Add("@NGAYSINH", SqlDbType.DateTime).Value = ngaysinh;
                cmd.Parameters.Add("@CHUCVU", SqlDbType.NVarChar).Value = chucvu;
                cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = diachi;
                cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = sdt;
                cmd.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = email;
                cmd.Parameters.Add("@QUYENHAN", SqlDbType.NVarChar).Value = quyenhan;
                cmd.ExecuteNonQuery();
            }
            catch (Exception sqlex)
            {
                throw sqlex;
            }
        }

        public void Themnguoidung1(string strStore, string taikhoan, string matkhau, string matkhaucap2, string macanbo)
        {
            try
            {
                cmd = new SqlCommand(strStore, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TAIKHOAN", SqlDbType.NVarChar).Value = taikhoan;
                cmd.Parameters.Add("@MATKHAU", SqlDbType.NVarChar).Value = matkhau;
                cmd.Parameters.Add("@MACANBO", SqlDbType.VarChar).Value = macanbo;
                cmd.Parameters.Add("@MATKHAUCAP2", SqlDbType.VarChar).Value = matkhaucap2;  
                cmd.ExecuteNonQuery();
            }
            catch (Exception sqlex)
            {
                throw sqlex;
            }
        }

        public void Themthongtinkhaisinh(string strStore, int sohokhau, string makhaisinh, string hotenkhaisinh, bool gioitinh, DateTime ngaysinh, string noisinh, string dantoc, string quoctich, string noidkkhaisinh, string quanhekhaisinh, string nguoikhaisinh, string canbohuongdan, string ghichu, DateTime ngaydkkhaisinh, string hinhanh)
        {
            try
            {
                cmd = new SqlCommand(strStore, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MAKHAISINH", SqlDbType.VarChar).Value = makhaisinh;
                cmd.Parameters.Add("@HOTENKHAISINH", SqlDbType.NVarChar).Value = hotenkhaisinh;
                cmd.Parameters.Add("@NGAYDKKHAISINH", SqlDbType.DateTime).Value = ngaydkkhaisinh;
                cmd.Parameters.Add("@GIOITINH", SqlDbType.Bit).Value = gioitinh;
                cmd.Parameters.Add("@NGAYSINH", SqlDbType.DateTime).Value = ngaysinh;
                cmd.Parameters.Add("@NOISINH", SqlDbType.NVarChar).Value = noisinh;
                cmd.Parameters.Add("@DANTOC", SqlDbType.NVarChar).Value = dantoc;
                cmd.Parameters.Add("@QUOCTICH", SqlDbType.NVarChar).Value = quoctich; 
                cmd.Parameters.Add("@MACANBO", SqlDbType.NVarChar).Value = canbohuongdan;
                cmd.Parameters.Add("@SOHOKHAU", SqlDbType.Int).Value = sohokhau;
                cmd.Parameters.Add("@GHICHU", SqlDbType.NVarChar).Value = ghichu;
                cmd.Parameters.Add("@NOIDKKHAISINH", SqlDbType.NVarChar).Value = noidkkhaisinh;
                cmd.Parameters.Add("@QUANHEKHAISINH", SqlDbType.NVarChar).Value = quanhekhaisinh;
                cmd.Parameters.Add("@NGUOIKHAISINH", SqlDbType.NVarChar).Value = nguoikhaisinh;
                cmd.Parameters.Add("@HINHANH", SqlDbType.NVarChar).Value = hinhanh;
                cmd.ExecuteNonQuery();
            }
            catch (Exception sqlex)
            {
                throw sqlex;
            }
        }

        public void Themquatrinh(string strStore, string makhaisinh, DateTime tuthangnam, DateTime denthangnam, string choo, string nghenghiep, string noilamviec, string ghichu)
        {
            try
            {
                cmd = new SqlCommand(strStore, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MAKHAISINH", SqlDbType.VarChar).Value =makhaisinh;
                cmd.Parameters.Add("@TUTHANGNAM", SqlDbType.DateTime).Value = tuthangnam;
                cmd.Parameters.Add("@DENTHANGNAM", SqlDbType.DateTime).Value = denthangnam;
                cmd.Parameters.Add("@CHOO", SqlDbType.NVarChar).Value = choo;
                cmd.Parameters.Add("@NGHENGHIEP", SqlDbType.NVarChar).Value = nghenghiep;
                cmd.Parameters.Add("@NOILAMVIEC", SqlDbType.NVarChar).Value = noilamviec;
                cmd.Parameters.Add("@GHICHU", SqlDbType.NVarChar).Value = ghichu;                
                cmd.ExecuteNonQuery();
            }
            catch (Exception sqlex)
            {
                throw sqlex;
            }
        }


        public void ChenGhiChu(string strStore, string ghichu)
        {
            try
            {
                cmd = new SqlCommand(strStore, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@GHICHU", SqlDbType.NVarChar).Value = ghichu;
                cmd.ExecuteNonQuery();
            }
            catch (Exception sqlex)
            {
                throw sqlex;
            }
        }

        public void Themdienbien1(string strStore, string makhaisinh, string noidi, DateTime ngaydi, string noiden, DateTime ngayden, string lydo, string thoihan, string macanbo, DateTime ngaylap)
        {
            try
            {
                cmd = new SqlCommand(strStore, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MAKHAISINH", SqlDbType.VarChar).Value = makhaisinh;
                cmd.Parameters.Add("@NOIDI", SqlDbType.NVarChar).Value = noidi;
                cmd.Parameters.Add("@NGAYDI", SqlDbType.DateTime).Value = ngaydi;
                cmd.Parameters.Add("@NOIDEN", SqlDbType.NVarChar).Value = noiden;
                cmd.Parameters.Add("@NGAYDEN", SqlDbType.DateTime).Value = ngayden;
                cmd.Parameters.Add("@LYDO", SqlDbType.NVarChar).Value = lydo;
                cmd.Parameters.Add("@THOIHAN", SqlDbType.NVarChar).Value = thoihan;
                cmd.Parameters.Add("@MACANBO", SqlDbType.VarChar).Value = macanbo;
                cmd.Parameters.Add("@NGAYLAP", SqlDbType.DateTime).Value = ngaylap;
                cmd.ExecuteNonQuery();
            }
            catch (Exception sqlex)
            {
                throw sqlex;
            }
        }

        public void Themtamvang1(string strStore, string makhaisinh, DateTime ngayvang, DateTime ngayketthuc, string noiden, string lydo, DateTime ngaylap, string macanbo, string ghichu, string nguoikhaibao)
        {
            try
            {
                cmd = new SqlCommand(strStore, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MAKHAISINH", SqlDbType.VarChar).Value = makhaisinh;
                cmd.Parameters.Add("@NGAYVANG", SqlDbType.DateTime).Value = ngayvang;
                cmd.Parameters.Add("@NGAYKETTHUC", SqlDbType.DateTime).Value = ngayketthuc;
                cmd.Parameters.Add("@NOIDEN", SqlDbType.NVarChar).Value = noiden;
                cmd.Parameters.Add("@LYDO", SqlDbType.NVarChar).Value = lydo;
                cmd.Parameters.Add("@NGAYLAP", SqlDbType.DateTime).Value = ngaylap;
                cmd.Parameters.Add("@MACANBO", SqlDbType.VarChar).Value = macanbo;
                cmd.Parameters.Add("@GHICHU", SqlDbType.NVarChar).Value = ghichu;
                cmd.Parameters.Add("@NGUOIKHAIBAO", SqlDbType.NVarChar).Value = nguoikhaibao;
                cmd.ExecuteNonQuery();
            }
            catch (Exception sqlex)
            {
                throw sqlex;
            }
        }
        
        public void Thembaotu1(string strStore, string makhaisinh, DateTime ngaymat, string lydo, string ghichu, string macanbo, string nguoikhai, DateTime ngaykhai)
        {
            try
            {
                cmd = new SqlCommand(strStore, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MAKHAISINH", SqlDbType.VarChar).Value = makhaisinh;
                cmd.Parameters.Add("@NGAYMAT", SqlDbType.DateTime).Value = ngaymat;
                cmd.Parameters.Add("@LYDOMAT", SqlDbType.NVarChar).Value = lydo;
                cmd.Parameters.Add("@GHICHU", SqlDbType.NVarChar).Value = ghichu;
                cmd.Parameters.Add("@MACANBO", SqlDbType.VarChar).Value = macanbo;
                cmd.Parameters.Add("@NGAYKHAI", SqlDbType.DateTime).Value = ngaykhai;
                cmd.Parameters.Add("@NGUOIKHAI", SqlDbType.NVarChar).Value = nguoikhai;
                cmd.ExecuteNonQuery();
            }
            catch (Exception sqlex)
            {
                throw sqlex;
            }
        }

        public void Themquanhe(string strStore, string makhaisinh, string hoten, string gioitinh, DateTime ngaysinh, string quanhe, string nghenghiep, string choo)
        {
            try
            {
                cmd = new SqlCommand(strStore, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MAKHAISINH", SqlDbType.VarChar).Value = makhaisinh;
                cmd.Parameters.Add("@HOTEN", SqlDbType.NVarChar).Value = hoten;
                cmd.Parameters.Add("@GIOITINH", SqlDbType.NVarChar).Value = gioitinh;
                cmd.Parameters.Add("@NGAYSINH", SqlDbType.DateTime).Value = ngaysinh;
                cmd.Parameters.Add("@QUANHE", SqlDbType.NVarChar).Value = quanhe;
                cmd.Parameters.Add("@NGHENGHIEP", SqlDbType.NVarChar).Value = nghenghiep;
                cmd.Parameters.Add("@CHOO", SqlDbType.NVarChar).Value = choo;

                cmd.ExecuteNonQuery();
            }
            catch (Exception sqlex)
            {
                throw sqlex;
            }
        }
        
        public void Themquanhe1(string strStore, string makhaisinh, string hoten, DateTime ngaysinh, string gioitinh, string quanhe, string dantoc, string quoctich, string choo, string nghenghiep)
        {
            try
            {
                cmd = new SqlCommand(strStore, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MAKHAISINH", SqlDbType.VarChar).Value = makhaisinh;
                cmd.Parameters.Add("@HOTEN", SqlDbType.NVarChar).Value = hoten;
                cmd.Parameters.Add("@GIOITINH", SqlDbType.NVarChar).Value = gioitinh;
                cmd.Parameters.Add("@NGAYSINH", SqlDbType.DateTime).Value = ngaysinh;
                cmd.Parameters.Add("@QUANHE", SqlDbType.NVarChar).Value = quanhe;
                cmd.Parameters.Add("@DANTOC", SqlDbType.NVarChar).Value = dantoc;
                cmd.Parameters.Add("@QUOCTICH", SqlDbType.NVarChar).Value = quoctich;
                cmd.Parameters.Add("@CHOO", SqlDbType.NVarChar).Value = choo;
                cmd.Parameters.Add("@NGHENGHIEP", SqlDbType.NVarChar).Value = nghenghiep;
                cmd.ExecuteNonQuery();
            }
            catch (Exception sqlex)
            {
                throw sqlex;
            }
        }

        public void Themkhenthuong(string strStore, string makhaisinh, DateTime ngaythang, string coquan, string sukien, string hinhthuc, DateTime ngayluu, string ghichu)
        {
            try
            {
                cmd = new SqlCommand(strStore, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MAKHAISINH", SqlDbType.VarChar).Value = makhaisinh;
                cmd.Parameters.Add("@NGAYTHANG", SqlDbType.DateTime).Value = ngaythang;
                cmd.Parameters.Add("@COQUAN", SqlDbType.NVarChar).Value = coquan;
                cmd.Parameters.Add("@SUKIEN", SqlDbType.NVarChar).Value = sukien;
                cmd.Parameters.Add("@HINHTHUC", SqlDbType.NVarChar).Value = hinhthuc;
                cmd.Parameters.Add("@NGAYLUU", SqlDbType.DateTime).Value = ngayluu;
                cmd.Parameters.Add("@GHICHU", SqlDbType.NVarChar).Value = ghichu;
                cmd.ExecuteNonQuery();
            }
            catch (Exception sqlex)
            {
                throw sqlex;
            }
        }

        public void Themtienan(string strStore, string makhaisinh, DateTime ngaythang, DateTime ngayluu, string tienan, string hinhthuc, string mucdo, string thoigian, string coquanxuly, string ghichu)
        {
            try
            {
                cmd = new SqlCommand(strStore, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MAKHAISINH", SqlDbType.VarChar).Value = makhaisinh;
                cmd.Parameters.Add("@NGAYTHANG", SqlDbType.DateTime).Value = ngaythang;
                cmd.Parameters.Add("@TIENAN", SqlDbType.NVarChar).Value = tienan;
                cmd.Parameters.Add("@HINHTHUC", SqlDbType.NVarChar).Value = hinhthuc;
                cmd.Parameters.Add("@MUCDO", SqlDbType.NVarChar).Value = mucdo;
                cmd.Parameters.Add("@THOIGIAN", SqlDbType.NVarChar).Value = thoigian;
                cmd.Parameters.Add("@COQUANXULY", SqlDbType.NVarChar).Value = coquanxuly;
                cmd.Parameters.Add("@NGAYLUU", SqlDbType.DateTime).Value = ngayluu;
                cmd.Parameters.Add("@GHICHU", SqlDbType.NVarChar).Value = ghichu;
                cmd.ExecuteNonQuery();
            }
            catch (Exception sqlex)
            {
                throw sqlex;
            }
        }

        public bool CapNhatDuLieuBang2(string strStore, string TenBang, string DieuKien, DataTable tbl)
        {
            try
            {
                cmd = new SqlCommand(strStore, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TENBANG", SqlDbType.NVarChar).Value = TenBang;
                cmd.Parameters.Add("@DIEUKIEN", SqlDbType.NVarChar).Value = DieuKien;
                da = new SqlDataAdapter(cmd);
                SqlCommandBuilder cmdb = new SqlCommandBuilder(da);
                da.Update(tbl);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

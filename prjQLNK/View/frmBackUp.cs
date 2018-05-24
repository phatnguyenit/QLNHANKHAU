using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraSplashScreen;
using System.IO;
using System.Text.RegularExpressions;

namespace prjQLNK
{
    public partial class frmBackUp : DevExpress.XtraEditors.XtraForm
    {
        public frmBackUp()
        {
            InitializeComponent();
            textEdit2.Text = "QLNK" + ngaythang;
        }

        string ngaythang = "_" + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + "_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString();

        SqlCommand cmd;
        public void Create_Cmd(string strSQL)
        {
            cmd = Ketnoi.con.CreateCommand();
            cmd.CommandText = strSQL;
            cmd.ExecuteNonQuery();
        }

        private bool Backup(string path)
        {
            try
            {
                SplashScreenManager.ShowDefaultWaitForm("Đang sao lưu", "Vui lòng chờ...");
                Ketnoi.con = new SqlConnection(Ketnoi.strConnection);
                Ketnoi.con.Open();
                ngaythang = "_" + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + "_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString();
                Create_Cmd("BACKUP DATABASE QLNK TO DISK =N'" + path + "\\" + textEdit2.Text + ".bak'");
                Ketnoi.con.Close();
                SplashScreenManager.CloseDefaultWaitForm();
                return true;
            }
            catch (Exception)
            {
                SplashScreenManager.CloseDefaultWaitForm();
                return false;
            }
        }

        string folderPath = "";
        private void textEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            folderPath = folderBrowserDialog1.SelectedPath = "";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
                textEdit1.Text = folderPath;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (textEdit2.Text != "")
            {
                if (IsValidFilename(textEdit2.Text) == true)
                {
                    if (textEdit1.Text != "")
                    {
                        if (Backup(textEdit1.Text) == true)
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                            ThongBao.Show(this, "Lỗi", "Không thể sao lưu CSDL");
                    }
                    else
                        XtraMessageBox.Show("Vui lòng chọn nơi sao lưu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    XtraMessageBox.Show("Tên file không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                XtraMessageBox.Show("Vui lòng đặt tên file", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        bool IsValidFilename(string testName)
        {
            Regex containsABadCharacter = new Regex("["
                  + Regex.Escape(new string(System.IO.Path.GetInvalidPathChars())) + "]");
            if (containsABadCharacter.IsMatch(testName)) { return false; };

            // other checks for UNC, drive-path format, etc

            return true;
        }
    }
}
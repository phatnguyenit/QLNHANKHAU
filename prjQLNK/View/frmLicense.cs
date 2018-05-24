using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FoxLearn.License;
using System.Management;
using System.Security.Cryptography;
using DevExpress.XtraSplashScreen;
using System.IO;
using System.Reflection;
using Microsoft.Win32;
using System.Diagnostics;

namespace prjQLNK
{
    public partial class frmLicense : DevExpress.XtraEditors.XtraForm
    {
        public frmLicense()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string productKey;
        const int ProductCode = 1;
        string diskid1, diskid2;

        public string GetHardDiskSerialNo()
        {
            ManagementClass mangnmt = new ManagementClass("Win32_LogicalDisk");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            string result = "";
            foreach (ManagementObject strt in mcol)
            {
                result += Convert.ToString(strt["VolumeSerialNumber"]);
            }
            return result;
        }
        public string SHA1(string number)
        {
            ASCIIEncoding ASCIIENC = new ASCIIEncoding();
            string strreturn = null;
            strreturn = String.Empty;
            byte[] bytesourcetxt = ASCIIENC.GetBytes(number);
            SHA1CryptoServiceProvider SHA1Hash = new SHA1CryptoServiceProvider();
            byte[] bytehash = SHA1Hash.ComputeHash(bytesourcetxt);
            foreach (byte b in bytehash)
            {
                strreturn += b.ToString("X8");
            }
            return strreturn;
        }
        public static String MD5(string txt)
        {
            String str = "";
            Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(txt);
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            foreach (Byte b in buffer)
            {
                str += b.ToString("X2");
            }
            return str;
        }

        string productKey_;
        private void LinceseAbout()
        {
            string LicensePath = Application.StartupPath + "\\License.lic";
            if (File.Exists(LicensePath))
            {
                FileInfo fInfo = new FileInfo(LicensePath);
                dpkCreatedate.Text = fInfo.LastWriteTime.ToString();
                LicenseInfo lic = new LicenseInfo();
                KeyManager km = new KeyManager(txtProductID.Text);
                int value = km.LoadSuretyFile(string.Format(@"{0}\License.lic", Application.StartupPath), ref lic);
                string productKey = lic.ProductKey;

                diskid1 = MD5(SHA1(GetHardDiskSerialNo())).Substring(7, 5);
                diskid2 = MD5(SHA1(GetHardDiskSerialNo())).Substring(14, 5);

                List<String> List_ = new List<string>();
                string[] lst = lic.ProductKey.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string line in lst)
                    List_.Add(line);

                productKey_ = List_[0] + "-" + diskid1 + "-" + List_[1] + "-" + diskid2 + "-" + List_[2] + "-" + List_[3] + "-?????-?????";
                txtProductKey.Text = productKey_;

                if (km.ValidKey(ref productKey))
                {
                    KeyValuesClass kv = new KeyValuesClass();
                    if (km.DisassembleKey(productKey, ref kv))
                    {
                        if (kv.Type == LicenseType.TRIAL)
                            txtRemaining.Text = string.Format("{0} ngày sử dụng", (kv.Expiration - DateTime.Now.Date).Days);
                        else
                            txtRemaining.Text = "Không giới hạn";
                    }
                }
            }
            else
                txtRemaining.Text = "Chưa đăng ký";
        }

        static void RestartApp(int pid, string applicationName)
        {
            // Wait for the process to terminate
            Process process = null;
            try
            {
                process = Process.GetProcessById(pid);
                process.WaitForExit(1000);
            }
            catch (ArgumentException)
            {
                Application.Exit();
            }
            Process.Start(applicationName, "");
        }

        private void groupControl2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            //this.Size = new Size(585, 285);
            //grpCom.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            //groupControl2.CustomHeaderButtons[0].Properties.Visible = false;
        }

        private void frmLicense_Load(object sender, EventArgs e)
        {
            txtProductID.Text = ComputerInfo.GetComputerId();
            txtDiskID.Text = GetHardDiskSerialNo();
            LinceseAbout();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            List<String> List_ = new List<string>();
            string[] lst = txtProductKey.Text.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lst)
                List_.Add(line);

            KeyManager km = new KeyManager(txtProductID.Text);
            if (List_.Count >= 7)
            {
                productKey = List_[0] + "-" + List_[2] + "-" + List_[4] + "-" + List_[5] + "-" + List_[6] + "-" + List_[7];

                diskid1 = MD5(SHA1(GetHardDiskSerialNo())).Substring(7, 5);
                diskid2 = MD5(SHA1(GetHardDiskSerialNo())).Substring(14, 5);

                if (km.ValidKey(ref productKey) && diskid1 == List_[1] && diskid2 == List_[3])
                {
                    KeyValuesClass kv = new KeyValuesClass();
                    if (km.DisassembleKey(productKey, ref kv))
                    {
                        LicenseInfo lic = new LicenseInfo();
                        lic.ProductKey = productKey;
                        lic.FullName = "Phần mềm quản lý nhân khẩu";
                        if (kv.Type == LicenseType.TRIAL)
                        {
                            lic.Day = kv.Expiration.Day;
                            lic.Month = kv.Expiration.Month;
                            lic.Year = kv.Expiration.Year;
                        }
                        km.SaveSuretyFile(string.Format(@"{0}\License.lic", Application.StartupPath), lic);
                        LinceseAbout();
                        txtProductKey.Text = productKey_;
                        if (XtraMessageBox.Show("Key đã được áp dụng. Khởi động lại phần mềm?", "Thành công", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            this.Close();
                            RestartApp(1, "prjQLNK.exe");
                        }
                    }
                }
                else
                    XtraMessageBox.Show("Lỗi bản quyền", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                XtraMessageBox.Show("Lỗi bản quyền", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
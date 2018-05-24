using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace prjQLNK
{
    public partial class frmCDHThong : DevExpress.XtraEditors.XtraForm
    {
        public frmCDHThong()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                unitHETHONG.CommitChanges();
                alertControl1.Show(this, "Thông báo", "Đã lưu cài đặt hệ thống");
                this.DialogResult = DialogResult.Yes;
            }
            catch (Exception)
            { }
        }
    }
}
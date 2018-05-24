using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace prjQLNK.Messages
{
    public static class MessagesBox
    {
        public static DialogResult Error(string message)
        {
            return XtraMessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult Success(string message)
        {
            return XtraMessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult Info(string message)
        {
            return XtraMessageBox.Show(message, "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult YesNo(string message)
        {
            return XtraMessageBox.Show(message, "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}

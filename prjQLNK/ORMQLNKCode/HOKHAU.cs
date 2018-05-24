using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace prjQLNK.QLNK
{

    public partial class HOKHAU
    {
        public HOKHAU(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            SOHOKHAU = Convert.ToInt32(AutoFormat.LayMaTuDong<HOKHAU>(Session, "SOHOKHAU", "{0:d8}"));
            NGAYDK = DateTime.Today;
        }
    }

}

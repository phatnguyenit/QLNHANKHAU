using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace prjQLNK.QLNK
{

    public partial class NHANKHAU
    {
        public NHANKHAU(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            MAKHAISINH = AutoFormat.LayMaTuDong<NHANKHAU>(Session, "MAKHAISINH", "{0:d8}");
            SOHOKHAU = Bientoancuc.sohokhau;
        }
    }

}

using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace prjQLNK.QLNK
{

    public partial class NHAPKHAU
    {
        public NHAPKHAU(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); NGAYNHAP = DateTime.Today; }
    }

}

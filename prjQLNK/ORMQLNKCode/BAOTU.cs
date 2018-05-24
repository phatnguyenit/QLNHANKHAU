using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace prjQLNK.QLNK
{

    public partial class BAOTU
    {
        public BAOTU(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            NGAYKHAI = DateTime.Today;
        }
    }

}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace prjQLNK.QLNK
{

    public partial class HOKHAU : XPLiteObject
    {
        int fSOHOKHAU;
        [Key]
        public int SOHOKHAU
        {
            get { return fSOHOKHAU; }
            set { SetPropertyValue<int>("SOHOKHAU", ref fSOHOKHAU, value); }
        }
        DateTime fNGAYDK;
        public DateTime NGAYDK
        {
            get { return fNGAYDK; }
            set { SetPropertyValue<DateTime>("NGAYDK", ref fNGAYDK, value); }
        }
        CANBO fMACANBO;
        [Size(10)]
        [Association(@"HOKHAUReferencesCANBO")]
        public CANBO MACANBO
        {
            get { return fMACANBO; }
            set { SetPropertyValue<CANBO>("MACANBO", ref fMACANBO, value); }
        }
        string fGHICHU;
        [Size(SizeAttribute.Unlimited)]
        public string GHICHU
        {
            get { return fGHICHU; }
            set { SetPropertyValue<string>("GHICHU", ref fGHICHU, value); }
        }
    }

}

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

    public partial class NGUOIDUNG : XPLiteObject
    {
        string fTAIKHOAN;
        [Key]
        [Size(20)]
        public string TAIKHOAN
        {
            get { return fTAIKHOAN; }
            set { SetPropertyValue<string>("TAIKHOAN", ref fTAIKHOAN, value); }
        }
        string fMATKHAU;
        [Size(20)]
        public string MATKHAU
        {
            get { return fMATKHAU; }
            set { SetPropertyValue<string>("MATKHAU", ref fMATKHAU, value); }
        }
        CANBO fMACANBO;
        [Size(10)]
        [Association(@"NGUOIDUNGReferencesCANBO")]
        public CANBO MACANBO
        {
            get { return fMACANBO; }
            set { SetPropertyValue<CANBO>("MACANBO", ref fMACANBO, value); }
        }
        string fMATKHAUCAP2;
        [Size(20)]
        public string MATKHAUCAP2
        {
            get { return fMATKHAUCAP2; }
            set { SetPropertyValue<string>("MATKHAUCAP2", ref fMATKHAUCAP2, value); }
        }
    }

}

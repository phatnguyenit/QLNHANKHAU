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

    public partial class HETHONG : XPLiteObject
    {
        int fID;
        [Key(true)]
        public int ID
        {
            get { return fID; }
            set { SetPropertyValue<int>("ID", ref fID, value); }
        }
        string fTENTINH;
        [Size(SizeAttribute.Unlimited)]
        public string TENTINH
        {
            get { return fTENTINH; }
            set { SetPropertyValue<string>("TENTINH", ref fTENTINH, value); }
        }
        DateTime fNTTU;
        public DateTime NTTU
        {
            get { return fNTTU; }
            set { SetPropertyValue<DateTime>("NTTU", ref fNTTU, value); }
        }
        DateTime fNTDEN;
        public DateTime NTDEN
        {
            get { return fNTDEN; }
            set { SetPropertyValue<DateTime>("NTDEN", ref fNTDEN, value); }
        }
        bool fTUDONGDN;
        public bool TUDONGDN
        {
            get { return fTUDONGDN; }
            set { SetPropertyValue<bool>("TUDONGDN", ref fTUDONGDN, value); }
        }
    }

}

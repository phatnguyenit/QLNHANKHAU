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

    public partial class HUYEN : XPLiteObject
    {
        int fID;
        [Key(true)]
        public int ID
        {
            get { return fID; }
            set { SetPropertyValue<int>("ID", ref fID, value); }
        }
        int fMAHUYEN;
        public int MAHUYEN
        {
            get { return fMAHUYEN; }
            set { SetPropertyValue<int>("MAHUYEN", ref fMAHUYEN, value); }
        }
        string fTENHUYEN;
        [Size(SizeAttribute.Unlimited)]
        public string TENHUYEN
        {
            get { return fTENHUYEN; }
            set { SetPropertyValue<string>("TENHUYEN", ref fTENHUYEN, value); }
        }
        string fLOAI;
        [Size(SizeAttribute.Unlimited)]
        public string LOAI
        {
            get { return fLOAI; }
            set { SetPropertyValue<string>("LOAI", ref fLOAI, value); }
        }
        int fMATINH;
        public int MATINH
        {
            get { return fMATINH; }
            set { SetPropertyValue<int>("MATINH", ref fMATINH, value); }
        }
    }

}

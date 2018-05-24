using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Threading;
using DevExpress.Xpo;
using System.Configuration;
using DevExpress.Xpo.DB;
using prjQLNK.Properties;
using DevExpress.LookAndFeel;
using System.Globalization;

namespace prjQLNK
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Language
            // Create a new object, representing the German culture.  
            CultureInfo culture = CultureInfo.CreateSpecificCulture("vi");
            // The following line provides localization for the application's user interface.  
            Thread.CurrentThread.CurrentUICulture = culture;
            // The following line provides localization for data formats.  
            Thread.CurrentThread.CurrentCulture = culture;
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(@"XpoProvider=MSSqlServer;data source=.\SQLEXPRESS;user id=sa;password=sa;initial catalog=QLNK;Persist Security Info=true", AutoCreateOption.DatabaseAndSchema);
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SkinName = Settings.Default["ApplicationSkinName"].ToString();
            Application.Run(new frmMain());
        }
    }
}

using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjQLNK
{
    class AutoFormat
    {
        public static string LayMaTuDong<T>(Session session, string keyColumnName, string format)
        {
            string ma = string.Empty;

            object count = session.Evaluate<T>(CriteriaOperator.Parse("Count()"), null);
            int max = Convert.ToInt32(count);

            ma = string.Format(format, ++max);
            while (session.GetObjectsInTransaction(session.GetClassInfo<T>(), CriteriaOperator.Parse(keyColumnName + "=?", ma), true).Count > 0)
                ma = string.Format(format, ++max);
            return ma;
        }
    }
}

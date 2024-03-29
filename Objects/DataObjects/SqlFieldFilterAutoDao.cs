using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BussinessObjects;

namespace DataObjects
{
    public class SqlFieldFilterAutoDao : SqlDaoBase<FieldFilterAuto>
    {
        public SqlFieldFilterAutoDao()
        {
            TableName = "cofFieldFilterAuto";
            EntityIDName = "FieldFilterAutoId";
            StoreProcedurePrefix = "spFieldFilterAuto_";
        }
        public SqlFieldFilterAutoDao(string tableName, string entityIDName, string storeProcedurePrefix) : base(tableName, entityIDName, storeProcedurePrefix) { }
        public int Clear(string tableName = "")
        {
            object[] parms = new object[] { "@tableName", tableName };
            return Convert.ToInt32(DbAdapter1.ExcecuteScalar("spFieldFilterAuto_Clear", true, parms));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BussinessObjects;

namespace DataObjects
{
    public class SqlFieldListAutoDao : SqlDaoBase<FieldListAuto>
    {
        public SqlFieldListAutoDao()
        {
            TableName = "cofFieldListAuto";
            EntityIDName = "FieldListAutoId";
            StoreProcedurePrefix = "spFieldListAuto_";
        }
        public SqlFieldListAutoDao(string tableName, string entityIDName, string storeProcedurePrefix) : base(tableName, entityIDName, storeProcedurePrefix) { }
        public int Clear(string tableName = "")
        {
            object[] parms = new object[] { "@tableName", tableName };
            return Convert.ToInt32(DbAdapter1.ExcecuteScalar("spFieldListAuto_Clear", true, parms));
        }
    }
}

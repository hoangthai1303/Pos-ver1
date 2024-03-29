using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BussinessObjects;

namespace DataObjects
{
    public class SqlFieldAddUpdateAutoDao : SqlDaoBase<FieldAddUpdateAuto>
    {
        public SqlFieldAddUpdateAutoDao()
        {
            TableName = "cofFieldAddUpdateAuto";
            EntityIDName = "FieldAddUpdateAutoId";
            StoreProcedurePrefix = "spFieldAddUpdateAuto_";
        }
        public SqlFieldAddUpdateAutoDao(string tableName, string entityIDName, string storeProcedurePrefix) : base(tableName, entityIDName, storeProcedurePrefix) { }

        public int Clear(string tableName = "")
        {
            object[] parms = new object[] { "@tableName", tableName };
            return Convert.ToInt32(DbAdapter1.ExcecuteScalar("spFieldAddUpdateAuto_Clear", true, parms));
        }

    }
}

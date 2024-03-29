using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BussinessObjects;

namespace DataObjects
{
    public class SqlDataSourceListAutoDao : SqlDaoBase<DataSourceListAuto>
    {
        public SqlDataSourceListAutoDao()
        {
            TableName = "cofDataSourceListAuto";
            EntityIDName = "DataSourceListAutoId";
            StoreProcedurePrefix = "spDataSourceListAuto_";
        }
        public SqlDataSourceListAutoDao(string tableName, string entityIDName, string storeProcedurePrefix) : base(tableName, entityIDName, storeProcedurePrefix) { }
        public int Clear(string tableName = "")
        {
            object[] parms = new object[] { "@tableName", tableName };
            return Convert.ToInt32(DbAdapter1.ExcecuteScalar("spDataSourceListAuto_Clear", true, parms));
        }
    }
}

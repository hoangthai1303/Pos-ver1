using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BussinessObjects;

namespace DataObjects
{
    public class SqlResourceListAutoDao : SqlDaoBase<ResourceListAuto>
    {
        public SqlResourceListAutoDao()
        {
            TableName = "cofResourceListAuto";
            EntityIDName = "ResourceListAutoId";
            StoreProcedurePrefix = "spResourceListAuto_";
        }
        public SqlResourceListAutoDao(string tableName, string entityIDName, string storeProcedurePrefix) : base(tableName, entityIDName, storeProcedurePrefix) { }
        public List<ResourceListAuto> GetFilter(string tableName = "")
        {
            object[] parms = new object[]
            {
                "@tableName",
                tableName
            };
            return DbAdapter1.ReadList<ResourceListAuto>(StoreProcedurePrefix + "GetFilter", Make, true, parms);
        }

        public int Clear(string tableName = "")
        {
            object[] parms = new object[]
            {
                "@tableName",
                tableName
            };
            return Convert.ToInt32(DbAdapter1.ExcecuteScalar("spResourceListAuto_Clear", true, parms));
        }
    }
}

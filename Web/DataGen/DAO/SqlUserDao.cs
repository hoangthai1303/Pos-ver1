using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eTraining.BussinessObjects;

namespace eTraining.DataObjects
{
    public class SqlUserDao : SqlDaoBase<User>
    {
        public SqlUserDao()
        {
            TableName = "tblUser";
            EntityIDName = "UserId";
            StoreProcedurePrefix = "spUser_";
        }
        public SqlUserDao(string tableName, string entityIDName, string storeProcedurePrefix) : base(tableName, entityIDName, storeProcedurePrefix) { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eTraining.BussinessObjects;

namespace eTraining.DataObjects
{
    public class SqlUserGroupDao : SqlDaoBase<UserGroup>
    {
        public SqlUserGroupDao()
        {
            TableName = "tblUserGroup";
            EntityIDName = "UserGroupId";
            StoreProcedurePrefix = "spUserGroup_";
        }
        public SqlUserGroupDao(string tableName, string entityIDName, string storeProcedurePrefix) : base(tableName, entityIDName, storeProcedurePrefix) { }
    }
}

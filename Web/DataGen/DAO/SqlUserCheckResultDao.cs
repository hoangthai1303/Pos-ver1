using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eTraining.BussinessObjects;

namespace eTraining.DataObjects
{
    public class SqlUserCheckResultDao : SqlDaoBase<UserCheckResult>
    {
        public SqlUserCheckResultDao()
        {
            TableName = "tblUserCheckResult";
            EntityIDName = "UserCheckResultId";
            StoreProcedurePrefix = "spUserCheckResult_";
        }
        public SqlUserCheckResultDao(string tableName, string entityIDName, string storeProcedurePrefix) : base(tableName, entityIDName, storeProcedurePrefix) { }
    }
}

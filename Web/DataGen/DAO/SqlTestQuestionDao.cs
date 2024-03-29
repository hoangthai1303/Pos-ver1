using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eTraining.BussinessObjects;

namespace eTraining.DataObjects
{
    public class SqlTestQuestionDao : SqlDaoBase<TestQuestion>
    {
        public SqlTestQuestionDao()
        {
            TableName = "tblTestQuestion";
            EntityIDName = "TestQuestionId";
            StoreProcedurePrefix = "spTestQuestion_";
        }
        public SqlTestQuestionDao(string tableName, string entityIDName, string storeProcedurePrefix) : base(tableName, entityIDName, storeProcedurePrefix) { }
    }
}

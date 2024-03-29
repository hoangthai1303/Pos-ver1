using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eTraining.BussinessObjects;

namespace eTraining.DataObjects
{
    public class SqlTestAnwserDao : SqlDaoBase<TestAnwser>
    {
        public SqlTestAnwserDao()
        {
            TableName = "tblTestAnwser";
            EntityIDName = "TestAnwserId";
            StoreProcedurePrefix = "spTestAnwser_";
        }
        public SqlTestAnwserDao(string tableName, string entityIDName, string storeProcedurePrefix) : base(tableName, entityIDName, storeProcedurePrefix) { }
    }
}

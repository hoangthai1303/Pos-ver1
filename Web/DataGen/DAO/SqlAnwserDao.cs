using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eTraining.BussinessObjects;

namespace eTraining.DataObjects
{
    public class SqlAnwserDao : SqlDaoBase<Anwser>
    {
        public SqlAnwserDao()
        {
            TableName = "tblAnwser";
            EntityIDName = "AnwserId";
            StoreProcedurePrefix = "spAnwser_";
        }
        public SqlAnwserDao(string tableName, string entityIDName, string storeProcedurePrefix) : base(tableName, entityIDName, storeProcedurePrefix) { }
    }
}

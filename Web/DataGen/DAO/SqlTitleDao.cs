using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eTraining.BussinessObjects;

namespace eTraining.DataObjects
{
    public class SqlTitleDao : SqlDaoBase<Title>
    {
        public SqlTitleDao()
        {
            TableName = "tblTitle";
            EntityIDName = "TitleId";
            StoreProcedurePrefix = "spTitle_";
        }
        public SqlTitleDao(string tableName, string entityIDName, string storeProcedurePrefix) : base(tableName, entityIDName, storeProcedurePrefix) { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eTraining.BussinessObjects;

namespace eTraining.DataObjects
{
    public class SqlLibraryDocumentDetailDao : SqlDaoBase<LibraryDocumentDetail>
    {
        public SqlLibraryDocumentDetailDao()
        {
            TableName = "tblLibraryDocumentDetail";
            EntityIDName = "LibraryDocumentDetailId";
            StoreProcedurePrefix = "spLibraryDocumentDetail_";
        }
        public SqlLibraryDocumentDetailDao(string tableName, string entityIDName, string storeProcedurePrefix) : base(tableName, entityIDName, storeProcedurePrefix) { }
    }
}

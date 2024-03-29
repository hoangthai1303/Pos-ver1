using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eTraining.BussinessObjects;

namespace eTraining.DataObjects
{
    public class SqlSubjectCategoryDao : SqlDaoBase<SubjectCategory>
    {
        public SqlSubjectCategoryDao()
        {
            TableName = "tblSubjectCategory";
            EntityIDName = "SubjectCategoryId";
            StoreProcedurePrefix = "spSubjectCategory_";
        }
        public SqlSubjectCategoryDao(string tableName, string entityIDName, string storeProcedurePrefix) : base(tableName, entityIDName, storeProcedurePrefix) { }
    }
}

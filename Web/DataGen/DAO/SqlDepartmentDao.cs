using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eTraining.BussinessObjects;

namespace eTraining.DataObjects
{
    public class SqlDepartmentDao : SqlDaoBase<Department>
    {
        public SqlDepartmentDao()
        {
            TableName = "tblDepartment";
            EntityIDName = "DepartmentId";
            StoreProcedurePrefix = "spDepartment_";
        }
        public SqlDepartmentDao(string tableName, string entityIDName, string storeProcedurePrefix) : base(tableName, entityIDName, storeProcedurePrefix) { }
    }
}

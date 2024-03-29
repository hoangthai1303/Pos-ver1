using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eTraining.BussinessObjects;

namespace eTraining.DataObjects
{
    public class SqlDepartmentRegionDao : SqlDaoBase<DepartmentRegion>
    {
        public SqlDepartmentRegionDao()
        {
            TableName = "tblDepartmentRegion";
            EntityIDName = "DepartmentRegionId";
            StoreProcedurePrefix = "spDepartmentRegion_";
        }
        public SqlDepartmentRegionDao(string tableName, string entityIDName, string storeProcedurePrefix) : base(tableName, entityIDName, storeProcedurePrefix) { }
    }
}

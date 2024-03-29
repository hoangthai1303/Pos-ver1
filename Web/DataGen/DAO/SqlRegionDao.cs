using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eTraining.BussinessObjects;

namespace eTraining.DataObjects
{
    public class SqlRegionDao : SqlDaoBase<Region>
    {
        public SqlRegionDao()
        {
            TableName = "tblRegion";
            EntityIDName = "RegionID";
            StoreProcedurePrefix = "spRegion_";
        }
        public SqlRegionDao(string tableName, string entityIDName, string storeProcedurePrefix) : base(tableName, entityIDName, storeProcedurePrefix) { }
    }
}

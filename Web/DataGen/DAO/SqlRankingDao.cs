using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eTraining.BussinessObjects;

namespace eTraining.DataObjects
{
    public class SqlRankingDao : SqlDaoBase<Ranking>
    {
        public SqlRankingDao()
        {
            TableName = "tblRanking";
            EntityIDName = "RankingId";
            StoreProcedurePrefix = "spRanking_";
        }
        public SqlRankingDao(string tableName, string entityIDName, string storeProcedurePrefix) : base(tableName, entityIDName, storeProcedurePrefix) { }
    }
}

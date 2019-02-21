using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTraining.BussinessObjects
{
    public class ProgramRanking : BusinessObject
    {
		             public Int64 UserID { get; set; } 

             public Int64 ProgramID { get; set; } 

             public int Status { get; set; } 

             public Int64 RankingID { get; set; } 

             public DateTime CreatedDate { get; set; } 

             public Int64 CreatedUser { get; set; } 


    }
}

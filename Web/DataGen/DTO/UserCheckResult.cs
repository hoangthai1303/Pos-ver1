using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTraining.BussinessObjects
{
    public class UserCheckResult : BusinessObject
    {
		             public Int64 UserID { get; set; } 

             public Int64 AnwserID { get; set; } 

             public int Status { get; set; } 

             public DateTime CreatedDate { get; set; } 

             public Int64 CreatedUser { get; set; } 


    }
}

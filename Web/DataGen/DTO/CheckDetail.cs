using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTraining.BussinessObjects
{
    public class CheckDetail : BusinessObject
    {
		             public string CheckID { get; set; } 

             public string Content { get; set; } 

             public int Status { get; set; } 

             public DateTime CreatedDate { get; set; } 

             public string CreatedUser { get; set; } 


    }
}

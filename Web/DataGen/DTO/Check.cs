using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTraining.BussinessObjects
{
    public class Check : BusinessObject
    {
		             public string DocumentID { get; set; } 

             public string CheckName { get; set; } 

             public int Status { get; set; } 

             public DateTime CreatedDate { get; set; } 

             public string CreatedUser { get; set; } 


    }
}

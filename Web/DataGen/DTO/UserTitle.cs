using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTraining.BussinessObjects
{
    public class UserTitle : BusinessObject
    {
		             public string UserTitleName { get; set; } 

             public Int64 ObjectTrainingID { get; set; } 

             public int Status { get; set; } 

             public DateTime CreatedDate { get; set; } 

             public Int64 CreatedUser { get; set; } 


    }
}

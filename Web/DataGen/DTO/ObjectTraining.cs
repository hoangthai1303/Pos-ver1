using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTraining.BussinessObjects
{
    public class ObjectTraining : BusinessObject
    {
		             public string ObjectTrainingName { get; set; } 

             public int ObjectTrainingType { get; set; } 

             public Int64 ReferID { get; set; } 

             public int Status { get; set; } 

             public DateTime CreatedDate { get; set; } 

             public Int64 CreatedUser { get; set; } 


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTraining.BussinessObjects
{
    public class TrainingType : BusinessObject
    {
		             public string TrainingTypeName { get; set; } 

             public DateTime CreatedDate { get; set; } 

             public Int64 CreatedUser { get; set; } 


    }
}

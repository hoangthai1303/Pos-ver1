using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTraining.BussinessObjects
{
    public class Department : BusinessObject
    {
		             public string DepartmentName { get; set; } 

             public int Status { get; set; } 

             public DateTime CreatedDate { get; set; } 

             public string CreatedUser { get; set; } 


    }
}

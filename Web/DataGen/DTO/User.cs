using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTraining.BussinessObjects
{
    public class User : BusinessObject
    {
		             public string UserName { get; set; } 

             public string Token { get; set; } 

             public int Status { get; set; } 

             public DateTime FirsRequestTime { get; set; } 

             public Int64 DepartmentID { get; set; } 

             public Int64 LocationID { get; set; } 

             public Int64 ObjectTrainingID { get; set; } 

             public Int64 UserGroupID { get; set; } 

             public string Avatar { get; set; } 

             public DateTime CreatedDate { get; set; } 

             public Int64 CreatedUser { get; set; } 


    }
}

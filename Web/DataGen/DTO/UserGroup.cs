using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTraining.BussinessObjects
{
    public class UserGroup : BusinessObject
    {
		             public string UserGroupName { get; set; } 

             public Int16 Status { get; set; } 

             public Int64 CreatedBy { get; set; } 

             public DateTime CreatedDate { get; set; } 


    }
}

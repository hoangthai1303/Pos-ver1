using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTraining.BussinessObjects
{
    public class LibraryDocumentDetail : BusinessObject
    {
		             public Int64 DocumentID { get; set; } 

             public int StepNo { get; set; } 

             public int PageForward { get; set; } 

             public string SubTitle { get; set; } 

             public string TimeForward { get; set; } 

             public int Status { get; set; } 

             public DateTime CreatedDate { get; set; } 

             public string CreatedUser { get; set; } 


    }
}

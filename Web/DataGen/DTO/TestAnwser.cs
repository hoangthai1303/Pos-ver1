using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTraining.BussinessObjects
{
    public class TestAnwser : BusinessObject
    {
		             public Int64 TestQuestionID { get; set; } 

             public string Content { get; set; } 

             public int No { get; set; } 

             public bool IsCorrect { get; set; } 

             public int Status { get; set; } 

             public DateTime CreatedDate { get; set; } 

             public Int64 CreatedUser { get; set; } 


    }
}

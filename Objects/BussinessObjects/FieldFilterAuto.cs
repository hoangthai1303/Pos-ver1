using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObjects
{
    public class FieldFilterAuto : BusinessObject
    {
		             public string TableRender { get; set; } 

             public string FieldName { get; set; } 

             public string DisplayName { get; set; } 

             public string PlaceHolder { get; set; } 

             public string FieldType { get; set; } 

             public string DataSource { get; set; } 

             public int Sort { get; set; } 

             public Int16 Status { get; set; } 

             public DateTime CreatedDate { get; set; } 

             public DateTime UpdatedDate { get; set; } 


    }
}

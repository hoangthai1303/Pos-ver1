using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObjects
{
    public class ResourceListAuto : BusinessObject
    {
        public string TableRender { get; set; }

        public string ResKey { get; set; }

        public string ResDisplay { get; set; }

        public Int16 Status { get; set; }

        public string LangCode { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }


    }
}

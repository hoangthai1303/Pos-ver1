using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTraining.BussinessObjects
{
    public class TestPart : BusinessObject
    {
        public Int64 TestID { get; set; }

        public int TotalQuestion { get; set; }

        public Int16 Status { get; set; }

        public DateTime CreatedDate { get; set; }

        public Int64 CreatedBy { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piterads.Models
{
    public class project
    {
        public int project_id { get; set; }
        public DateOnly order_date { get; set; }
        public DateOnly deadline { get; set; }
        public int budget { get; set; }
        public int total_amount { get; set; }
        public int type_project_id { get; set; }
    }
}
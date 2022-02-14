using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdDemo.Models
{
    public class AcceptedRequests
    {
        public int Id { get; set; }
        public string Postedby { get; set; }
        public DateTime PostedOn { get; set; }
        public bool IsAvailable { get; set; }
        public string AcceptedBy { get; set; }
        public DateTime AcceptedOn { get; set; }

    }
}

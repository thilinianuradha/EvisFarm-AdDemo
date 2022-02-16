using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdDemo.Models
{
    public class Vendor
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Location { get; set; }
        public int NoofPendingRequests { get; set; }
        public int NoofInprogressAds { get; set; }
        public int NoofClosedAds { get; set; }



        public List<PendingRequest> Pending_Requests { get; set; }
    }
}

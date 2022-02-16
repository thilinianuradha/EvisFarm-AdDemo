using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdDemo.Models
{
    public class PendingRequest
    {
        public int Id { get; set; }
        public int AdvertisementId { get; set; }
        public Advertisement  Advertisement { get; set; }
        public int PostedBy { get; set; }
        public Vendor Vendor { get; set; }
        public DateTime PostedOn { get; set; }
        public int No_of_requests { get; set; }
        public bool IsAccepted { get; set; }
        public DateTime AcceptedOn { get; set; }
        







    }
}

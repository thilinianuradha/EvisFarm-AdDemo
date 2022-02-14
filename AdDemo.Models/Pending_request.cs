using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdDemo.Models
{
    public class Pending_request
    {
        public int Id { get; set; }
        public int AnnouncementId { get; set; }
        public String PostedBy { get; set; }
        public DateTime PostedOn { get; set; }
        public bool IsAccepted { get; set; }
        public DateTime AcceptedOn { get; set; }
        public int No_of_requests { get; set; }






    }
}

using AdDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdDemo.Services.PendingRequests.ViewModels
{
    public class PendingRequestDto
    {
        public int Id { get; set; }
        public int AdvertisementId { get; set; }
        public int PostedBy { get; set; }
        public DateTime PostedOn { get; set; }
        public int No_of_requests { get; set; }
        public bool IsAccepted { get; set; }
        public DateTime AcceptedOn { get; set; }

    }
}

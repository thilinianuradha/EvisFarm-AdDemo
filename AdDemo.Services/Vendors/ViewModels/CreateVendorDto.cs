using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdDemo.Services.Vendors.ViewModels
{
    public class CreateVendorDto
    {
        public string FullName { get; set; }
        public string Location { get; set; }
        public int NoofPendingRequests { get; set; }
        public int NoofInprogressAds { get; set; }
        public int NoofClosedAds { get; set; }
        public int CropId { get; set; }
    }
}

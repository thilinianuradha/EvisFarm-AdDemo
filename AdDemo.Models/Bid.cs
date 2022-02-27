using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdDemo.Models
{
    public class Bid
    {
        public int Id { get; set; }
        public int VendorId { get; set; }
        public int AnnouncementId { get; set; }
        public int BuyerId { get; set; }
        public decimal BidValue { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime LastUpdatedOn { get; set; }
        public DateTime DeletedOn { get; set; }
        public string DeletingRemarks { get; set; }


    }
}

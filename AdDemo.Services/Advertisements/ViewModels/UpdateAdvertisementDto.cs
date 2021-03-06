using AdDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdDemo.Services.ViewModels
{
    public class UpdateAdvertisementDto
    {
        public string Location { get; set; }
        public string? Description { get; set; }
        public string? EstimatedPrice { get; set; }
        public string? AreaofCultivation { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime Lastmodifieddate { get; set; }
        public bool IsAvailable { get; set; }
        public Boolean IsAccepted { get; set; }
        public DateTime? AcceptedOn { get; set; }
        public string AcceptedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int CropId { get; set; }
        public Crop crop { get; set; }

    }
}

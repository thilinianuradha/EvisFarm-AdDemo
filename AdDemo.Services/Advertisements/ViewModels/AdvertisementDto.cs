using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdDemo.Services.ViewModels
{
    public class AdvertisementDto
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string? Description { get; set; }
        public string? EstimatedPrice { get; set; }
        public string? AreaofCultivation { get; set; }
        public string? NameofOwner { get; set; }
    
      
    }
}

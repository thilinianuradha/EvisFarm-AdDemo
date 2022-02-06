using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdDemo.Services.Crops.ViewModels
{
    public class CropDto
    {
        public int Id { get; set; }
        public string? CropType { get; set; }
        public string? CropName { get; set; }
        public bool IsAvailable { get; set; }
        public int NoOfAdvertisements { get; set; }
    }
}

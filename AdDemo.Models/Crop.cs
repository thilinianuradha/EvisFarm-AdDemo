using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdDemo.Models
{
    public class Crop
    {
        public int Id { get; set; }
        public string? CropType { get; set; }
        public string? CropName { get; set; }
        public bool IsAvailable { get; set; }
        public int NoOfAdvertisements { get; set; }

        //public List<Advertisement> Advertisements { get; set;}



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdDemo.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public char Password { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdatedOn { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime DeletedOn { get; set; }
        public string DeletedRemarks { get; set; }

    }
}

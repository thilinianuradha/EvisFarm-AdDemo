using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdDemo.Services.Buyers.ViewModels
{
    public class CreateBuyerDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public DateTime JoinedOn { get; set; }
        public bool IsActive { get; set; }
        public bool IsModified { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public string Modify_remarks { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeletedOn { get; set; }
        public string DeletedBy { get; set; }
       


    }
}

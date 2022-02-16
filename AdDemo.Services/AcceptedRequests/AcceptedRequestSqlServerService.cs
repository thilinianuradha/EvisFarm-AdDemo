using AdDemo.DataAccess;
using AdDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdDemo.Services.AcceptedRequests
{
    public class AcceptedRequestSqlServerService : IAcceptedRequestRepository
    {
        private readonly AdvertisementDbContext _context = new AdvertisementDbContext();
        public List<AcceptedRequest> AllAcceptedRequests()
        {
            return _context.AcceptedRequests.ToList();
        }

        public AcceptedRequest GetAcceptedRequest(int id)
        {
            return _context.AcceptedRequests.Find(id);
        }

       
    }
}

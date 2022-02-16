using AdDemo.DataAccess;
using AdDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdDemo.Services.PendingRequests
{
    public class PendingRequestSqlServerService : IPendingRequestRepository
    {
        private readonly AdvertisementDbContext _context = new AdvertisementDbContext();

        public object AllPendingRequests()
        {
           return _context.pendingRequests.ToList();
        }

        public Pending_Request GetAPendingRequest(int id)
        {
            return _context.pendingRequests.Find(id);
        }

        public List<Pending_Request> PendingRequests()
        {
            throw new NotImplementedException();
        }
    }
}

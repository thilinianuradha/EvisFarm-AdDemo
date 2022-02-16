using AdDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdDemo.Services.PendingRequests
{
    public interface IPendingRequestRepository
    {
        public List<Pending_Request> PendingRequests();
        public Pending_Request GetAPendingRequest(int id);
        object AllPendingRequests();
    }
}

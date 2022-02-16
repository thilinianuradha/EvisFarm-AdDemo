using AdDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdDemo.Services.AcceptedRequests
{
    public interface IAcceptedRequestRepository
    {

        public List<AcceptedRequest> AllAcceptedRequests();
        public AcceptedRequest GetAcceptedRequest(int id);
    }
}

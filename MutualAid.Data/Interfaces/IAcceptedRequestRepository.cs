using MutualAid.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MutualAid.Data.Interfaces
{
    public interface IAcceptedRequestRepository : IBaseRepository<AcceptedRequest>
    {
        //GET
        Task<AcceptedRequest> GetAcceptedRequestByRequestIdAsync(int reqId);
        Task<IEnumerable<AcceptedRequest>> GetAcceptedRequestsByUserIdAsync(int userId);
        Task<IEnumerable<AcceptedRequest>> GetAllAcceptedRequestsAsync();

        //POST
        Task<bool> AddAcceptedRequestAsync(AcceptedRequest acceptedRequest);
    }
}

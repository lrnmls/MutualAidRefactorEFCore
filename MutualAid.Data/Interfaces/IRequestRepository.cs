using MutualAid.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MutualAid.Data.Interfaces
{
    public interface IRequestRepository : IBaseRepository<Request>
    {
        //GET
        Task<IEnumerable<Request>> GetRequestsByUserIdAsync(int userId);
        Task<Request> GetRequestByRequestIdAsync(int reqId);
        Task<IEnumerable<Request>> GetOtherUsersRequestsNotAcceptedAsync(int userId);
        Task<IEnumerable<Request>> GetAllRequestsAsync();

        //POST
        //Task<bool> AddRequestToAcceptedTableAsync(AcceptedRequest acceptedRequest);
        //void ChangeAcceptedToTrue(Request req);
    }
}

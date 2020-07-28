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
        Task<IEnumerable<Request>> GetRequestsByUserId(int userId);
        Task<Request> GetRequestByRequestIdAsync(int reqId);
        Task<IEnumerable<Request>> GetOtherUsersRequestsNotAccepted(int userId);

        //POST
        Task<bool> AddRequestToAcceptedTable(int reqId, int userId);
        Task<bool> ChangeAcceptedToTrue(Request req);
        Task<bool> ChangeAcceptedToFalse(Request req);
    }
}

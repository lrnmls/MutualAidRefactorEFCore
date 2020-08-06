using MutualAid.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutualAid.UI.Interfaces
{
    public interface IAcceptedRequestViewService : IBaseViewService
    {
        //GET
        Task<AcceptedRequestViewModel> GetAcceptedRequestByRequestIdAsync(int reqId);
        Task<IEnumerable<AcceptedRequestViewModel>> GetAcceptedRequestsByUserIdAsync(int userId);
        Task<IEnumerable<AcceptedRequestViewModel>> GetAllAcceptedRequestsAsync();

        //POST
        Task<bool> AddAcceptedRequestAsync(AcceptedRequestViewModel model);
    }
}

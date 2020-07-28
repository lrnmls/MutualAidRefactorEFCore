using MutualAid.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutualAid.UI.Interfaces
{
    public interface IRequestViewService : IBaseViewService
    {
        //GET
        Task<RequestViewModel> GetRequestByRequestIdAsync(int reqId);
        Task<IEnumerable<RequestViewModel>> GetRequestsByUserId(int userId);
        Task<IEnumerable<RequestViewModel>> GetOtherUsersRequestsNotAccepted(int userId);
        Task<IEnumerable<RequestViewModel>> GetAllRequestsAsync();

        //POST
        Task<bool> AddRequestAsync(RequestViewModel model);
        Task<bool> UpdateRequestAsync(RequestViewModel model);
        Task<bool> DeleteRequestAsync(RequestViewModel model);
    }
}

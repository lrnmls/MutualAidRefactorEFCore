using MutualAid.Data.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MutualAid.Application.Interfaces
{
    public interface IRequestService : IBaseService
    {
        //GET
        Task<RequestDto> GetRequestByRequestIdAsync(int reqId);
        Task<IEnumerable<RequestDto>> GetRequestsByUserIdAsync(int userId);
        Task<IEnumerable<RequestDto>> GetOtherUsersRequestsNotAcceptedAsync(int userId);
        Task<IEnumerable<RequestDto>> GetAllRequestsAsync();

        //POST
        Task<bool> AddRequestAsync(RequestDto reqDto);
        Task<bool> UpdateRequestAsync(RequestDto reqDto);
        Task<bool> DeleteRequestAsync(RequestDto reqDto);
    }
}

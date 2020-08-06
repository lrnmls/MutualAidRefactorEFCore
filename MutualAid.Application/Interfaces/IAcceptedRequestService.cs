using MutualAid.Data.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MutualAid.Application.Interfaces
{
    public interface IAcceptedRequestService : IBaseService
    {
        //GET
        Task<AcceptedRequestDto> GetAcceptedRequestByRequestIdAsync(int reqId);
        Task<IEnumerable<AcceptedRequestDto>> GetAcceptedRequestsByUserIdAsync(int userId);
        Task<IEnumerable<AcceptedRequestDto>> GetAllAcceptedRequestsAsync();

        //POST
        Task<bool> AddAcceptedRequestAsync(AcceptedRequestDto acceptedRequestDto);
    }
}

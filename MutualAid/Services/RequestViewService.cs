using AutoMapper;
using MutualAid.Application.Interfaces;
using MutualAid.Data.DTO;
using MutualAid.UI.Interfaces;
using MutualAid.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutualAid.UI.Services
{
    public class RequestViewService : BaseViewService, IRequestViewService
    {
        private readonly IRequestService requestService;
        private readonly IMapper mapper;

        public RequestViewService(IRequestService requestService, IMapper mapper) : base(mapper, requestService)
        {
            this.requestService = requestService;
            this.mapper = mapper;
        }

        //GET methods
        public async Task<RequestViewModel> GetRequestByRequestIdAsync(int reqId)
        {
            var reqDto = await requestService.GetRequestByRequestIdAsync(reqId);
            return mapper.Map<RequestViewModel>(reqDto);
        }

        public async Task<IEnumerable<RequestViewModel>> GetRequestsByUserIdAsync(int userId)
        {
            var reqDto = await requestService.GetRequestsByUserIdAsync(userId);
            return mapper.Map<IEnumerable<RequestViewModel>>(reqDto);
        }

        public async Task<IEnumerable<RequestViewModel>> GetOtherUsersRequestsNotAcceptedAsync(int userId)
        {
            var reqs = await requestService.GetOtherUsersRequestsNotAcceptedAsync(userId);
            return mapper.Map<IEnumerable<RequestViewModel>>(reqs);
        }

        public async Task<IEnumerable<RequestViewModel>> GetAllRequestsAsync()
        {
            var reqsDto = await requestService.GetAllRequestsAsync();
            return mapper.Map<IEnumerable<RequestViewModel>>(reqsDto);
        }

        //POST methods
        public async Task<bool> AddRequestAsync(RequestViewModel model)
        {
            var reqDto = mapper.Map<RequestDto>(model);
            return await requestService.AddRequestAsync(reqDto);
        }

        public async Task<bool> UpdateRequestAsync(RequestViewModel model)
        {
            var reqDto = mapper.Map<RequestDto>(model);
            return await requestService.UpdateRequestAsync(reqDto);
        }

        public async Task<bool> DeleteRequestAsync(RequestViewModel model)
        {
            var reqDto = mapper.Map<RequestDto>(model);
            return await requestService.DeleteRequestAsync(reqDto);
        }

        //public async Task<bool> AddRequestToAcceptedTableAsync(AcceptedRequestViewModel model)
        //{
        //    var reqDto = mapper.Map<AcceptedRequestDto>(model);
        //    return await requestService.AddRequestToAcceptedTableAsync(reqDto);
        //}
    }
}

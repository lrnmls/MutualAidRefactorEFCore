using AutoMapper;
using MutualAid.Application.Interfaces;
using MutualAid.Application.Services;
using MutualAid.Data.DTO;
using MutualAid.Data.Interfaces;
using MutualAid.UI.Interfaces;
using MutualAid.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutualAid.UI.Services
{
    public class AcceptedRequestViewService : BaseViewService, IAcceptedRequestViewService
    {
        private readonly IAcceptedRequestService acceptedRequestService;
        private readonly IMapper mapper;

        public AcceptedRequestViewService(IAcceptedRequestService acceptedRequestService, IMapper mapper) : base(mapper, acceptedRequestService)
        {
            this.acceptedRequestService = acceptedRequestService;
            this.mapper = mapper;
        }

        //GET methods
        public async Task<AcceptedRequestViewModel> GetAcceptedRequestByRequestIdAsync(int reqId)
        {
            var reqDto = await acceptedRequestService.GetAcceptedRequestByRequestIdAsync(reqId);
            return mapper.Map<AcceptedRequestViewModel>(reqDto);
        }

        public async Task<IEnumerable<AcceptedRequestViewModel>> GetAcceptedRequestsByUserIdAsync(int userId)
        {
            var reqDtos = await acceptedRequestService.GetAcceptedRequestsByUserIdAsync(userId);
            return mapper.Map<IEnumerable<AcceptedRequestViewModel>>(reqDtos);
        }

        public async Task<IEnumerable<AcceptedRequestViewModel>> GetAllAcceptedRequestsAsync()
        {
            var reqDtos = await acceptedRequestService.GetAllAcceptedRequestsAsync();
            return mapper.Map<IEnumerable<AcceptedRequestViewModel>>(reqDtos);
        }

        //POST methods
        public async Task<bool> AddAcceptedRequestAsync(AcceptedRequestViewModel model)
        {
            var reqDto = mapper.Map<AcceptedRequestDto>(model);
            return await acceptedRequestService.AddAcceptedRequestAsync(reqDto);
        }
    }
}

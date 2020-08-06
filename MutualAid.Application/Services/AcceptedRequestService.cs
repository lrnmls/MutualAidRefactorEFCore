using AutoMapper;
using MutualAid.Application.Interfaces;
using MutualAid.Data.DTO;
using MutualAid.Data.Entities;
using MutualAid.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MutualAid.Application.Services
{
    public class AcceptedRequestService : BaseService<AcceptedRequest>, IAcceptedRequestService
    {
        private readonly IAcceptedRequestRepository acceptedRequestRepository;
        private readonly IMapper mapper;

        public AcceptedRequestService(IAcceptedRequestRepository acceptedRequestRepository, IMapper mapper) : base(acceptedRequestRepository, mapper)
        {
            this.acceptedRequestRepository = acceptedRequestRepository;
            this.mapper = mapper;
        }

        //GET methods
        public async Task<AcceptedRequestDto> GetAcceptedRequestByRequestIdAsync(int reqId)
        {
            var req = await acceptedRequestRepository.GetAcceptedRequestByRequestIdAsync(reqId);
            return mapper.Map<AcceptedRequestDto>(req);
        }

        public async Task<IEnumerable<AcceptedRequestDto>> GetAcceptedRequestsByUserIdAsync(int userId)
        {
            var reqs = await acceptedRequestRepository.GetAcceptedRequestsByUserIdAsync(userId);
            return mapper.Map<IEnumerable<AcceptedRequestDto>>(reqs);
        }

        public async Task<IEnumerable<AcceptedRequestDto>> GetAllAcceptedRequestsAsync()
        {
            var reqs = await acceptedRequestRepository.GetAllAcceptedRequestsAsync();
            return mapper.Map<IEnumerable<AcceptedRequestDto>>(reqs);
        }

        //POST methods

        public async Task<bool> AddAcceptedRequestAsync(AcceptedRequestDto acceptedRequestDto)
        {
            var req = mapper.Map<AcceptedRequest>(acceptedRequestDto);
            return await acceptedRequestRepository.AddAcceptedRequestAsync(req);
        }
    }
}

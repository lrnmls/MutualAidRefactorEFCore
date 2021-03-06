﻿using AutoMapper;
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
    public class RequestService : BaseService<Request>, IRequestService
    {
        private readonly IRequestRepository requestRepository;
        private readonly IMapper mapper;

        public RequestService(IMapper mapper, IRequestRepository requestRepository) : base(requestRepository, mapper)
        {
            this.requestRepository = requestRepository;
            this.mapper = mapper;
        }

        public async Task<RequestDto> GetRequestByRequestIdAsync(int reqId)
        {
            var req = await requestRepository.GetRequestByRequestIdAsync(reqId);
            return mapper.Map<RequestDto>(req);
        }

        public async Task<IEnumerable<RequestDto>> GetRequestsByUserIdAsync(int userId)
        {
            var reqs = await requestRepository.GetRequestsByUserIdAsync(userId);
            return mapper.Map<IEnumerable<RequestDto>>(reqs);
        }

        public async Task<IEnumerable<RequestDto>> GetOtherUsersRequestsNotAcceptedAsync(int userId)
        {
            var reqs = await requestRepository.GetOtherUsersRequestsNotAcceptedAsync(userId);
            return mapper.Map<IEnumerable<RequestDto>>(reqs);
        }

        public async Task<IEnumerable<RequestDto>> GetAllRequestsAsync()
        {
            var reqs = await requestRepository.GetAllRequestsAsync();
            return mapper.Map<IEnumerable<RequestDto>>(reqs);
        }

        //POST methods
        public async Task<bool> AddRequestAsync(RequestDto reqDto)
        {
            var req = mapper.Map<Request>(reqDto);
            return await requestRepository.AddAsync(req);
        }

        public async Task<bool> UpdateRequestAsync(RequestDto reqDto)
        {
            var req = mapper.Map<Request>(reqDto);
            return await requestRepository.UpdateAsync(req);
        }

        public async Task<bool> DeleteRequestAsync(RequestDto reqDto)
        {
            var req = mapper.Map<Request>(reqDto);
            return await requestRepository.DeleteAsync(req);
        }

        //public async Task<bool> AddRequestToAcceptedTableAsync(AcceptedRequestDto acceptedRequestDto)
        //{
        //    var req = mapper.Map<AcceptedRequest>(acceptedRequestDto);
        //    return await requestRepository.AddRequestToAcceptedTableAsync(req);
        //}
    }
}

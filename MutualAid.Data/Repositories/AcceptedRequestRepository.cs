using Microsoft.EntityFrameworkCore;
using MutualAid.Data.Context;
using MutualAid.Data.Entities;
using MutualAid.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutualAid.Data.Repositories
{
    public class AcceptedRequestRepository : BaseEntityRepository<AcceptedRequest>, IAcceptedRequestRepository
    {
        IRequestRepository requestRepository;

        public AcceptedRequestRepository(MutualAidContext dbContext, IRequestRepository requestRepository) : base(dbContext)
        {
            this.requestRepository = requestRepository;
        }

        //GET methods
        public async Task<AcceptedRequest> GetAcceptedRequestByRequestIdAsync(int reqId)
        {
            return await DbContext.Set<AcceptedRequest>()
                .Include(x => x.User)
                .Include(x => x.Request)
                .FirstOrDefaultAsync(x => x.Id == reqId);
        }

        public async Task<IEnumerable<AcceptedRequest>> GetAcceptedRequestsByUserIdAsync(int userId)
        {
            return await DbContext.Set<AcceptedRequest>()
              .Where(x => x.UserId == userId)
              .Where(x => x.UserId == userId)
              .Include(x => x.User)
              .Include(x => x.Request)
              .ToListAsync();
        }

        public async Task<IEnumerable<AcceptedRequest>> GetAllAcceptedRequestsAsync()
        {
            return await DbContext.Set<AcceptedRequest>()
               .Include(x => x.User)
               .Include(x => x.Request)
               .ToListAsync();
        }

        //POST methods
        public async Task<bool> AddAcceptedRequestAsync(AcceptedRequest acceptedRequest)
        {
            DbContext.Set<AcceptedRequest>().Add(acceptedRequest);
            var req = await requestRepository.GetRequestByRequestIdAsync(acceptedRequest.RequestId);
            ChangeAcceptedToTrue(req);
            return await DbContext.SaveChangesAsync() > 0;
        }

        private void ChangeAcceptedToTrue(Request req)
        {
            req.IsAccepted = true;
            DbContext.Set<Request>().Update(req).Property(x => x.IsAccepted);
        }
    }
}

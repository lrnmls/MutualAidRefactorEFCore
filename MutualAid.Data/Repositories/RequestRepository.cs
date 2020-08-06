using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using MutualAid.Data.Context;
using MutualAid.Data.Entities;
using MutualAid.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MutualAid.Data.Repositories
{
    public class RequestRepository : BaseEntityRepository<Request>, IRequestRepository
    {
        public RequestRepository(MutualAidContext dbContext) : base(dbContext)
        {

        }

        //GET methods
        public async Task<IEnumerable<Request>> GetRequestsByUserIdAsync(int userId)
        {
            return await DbContext.Set<Request>()
                .Where(x => x.UserId == userId)
                .Include(x => x.User)
                .ToListAsync();
        }

        public async Task<Request> GetRequestByRequestIdAsync(int reqId)
        {
            return await DbContext.Set<Request>()
                .Include(x => x.User)
                .FirstOrDefaultAsync(x => x.Id == reqId);
        }

        public async Task<IEnumerable<Request>> GetAllRequestsAsync()
        {
            return await DbContext.Set<Request>()
                .Include(x => x.User)
                .ToListAsync();
        }

        public async Task<IEnumerable<Request>> GetOtherUsersRequestsNotAcceptedAsync(int userId)
        {
            return await DbContext.Set<Request>()
                .Where(x => x.UserId != userId)
                .Where(x => x.IsAccepted == false)
                .Include(x => x.User)
                .ToListAsync();
        }

        //public async Task<bool> AddRequestToAcceptedTableAsync(AcceptedRequest acceptedRequest)
        //{
        //    DbContext.Set<AcceptedRequest>().Add(acceptedRequest);
        //    var req = await GetRequestByRequestIdAsync(acceptedRequest.RequestId);
        //    ChangeAcceptedToTrue(req);
        //    return await DbContext.SaveChangesAsync() > 0;
        //}

        //public void ChangeAcceptedToTrue(Request req)
        //{
        //    req.IsAccepted = true;
        //    DbContext.Set<Request>().Update(req).Property(x => x.IsAccepted);
        //}
    }
}

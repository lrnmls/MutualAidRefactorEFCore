using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MutualAid.UI.Interfaces;
using MutualAid.UI.Models;

namespace MutualAid.UI.Controllers
{
    public class UserRequestController : Controller
    {
        private readonly IAuthViewService authViewService;
        private readonly IRequestViewService requestViewService;

        public UserRequestController(IAuthViewService authViewService, IRequestViewService requestViewService)
        {
            this.authViewService = authViewService;
            this.requestViewService = requestViewService;
        }

        public async Task<IActionResult> AcceptRequestConfirmation(int reqId, int userId)
        {
            var user = authViewService.GetCurrentUser();
            var req = await requestViewService.GetRequestByRequestIdAsync(reqId);
            //method for adding to accepted requests and changing byte in request table to 1
            return View();
        }

        public IActionResult RequestSubmissionConfirmation(RequestViewModel model)
        {
            return View(model);
        }

        public async Task<IActionResult> ViewMyRequests()
        {
            var user = authViewService.GetCurrentUser();
            var reqs = await requestViewService.GetRequestsByUserId(user.Id);
            return View(reqs);
        }

        public async Task<IActionResult> ViewRequests()
        {
            var user = authViewService.GetCurrentUser();
            var reqs = await requestViewService.GetOtherUsersRequestsNotAccepted(user.Id);
            return View(reqs);
        }
    }
}

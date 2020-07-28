using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MutualAid.UI.Interfaces;

namespace MutualAid.UI.Controllers
{
    public class AdminRequestController : Controller
    {
        private readonly IRequestViewService requestViewService;
        private readonly IAuthViewService authViewService;

        public AdminRequestController(IRequestViewService requestViewService, IAuthViewService authViewService)
        {
            this.requestViewService = requestViewService;
            this.authViewService = authViewService;
        }

        //admin only
        public async Task<IActionResult> ViewAllRequests()
        {
            var reqs = await requestViewService.GetAllRequestsAsync();
            return View(reqs);
        }
    }
}

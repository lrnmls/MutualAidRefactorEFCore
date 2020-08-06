using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using MutualAid.Data.Entities;
using MutualAid.UI.Interfaces;
using MutualAid.UI.Models;
using MutualAidRefactorEFCore.Data.DTO;

namespace MutualAid.UI.Controllers
{
    public class RequestController : Controller
    {
        private readonly IRequestViewService requestViewService;
        private readonly IAcceptedRequestViewService acceptedRequestViewService;
        private readonly IAuthViewService authViewService;
        private readonly IUserViewService userViewService;

        public RequestController(IRequestViewService requestViewService, IAuthViewService authViewService, IUserViewService userViewService, IAcceptedRequestViewService acceptedRequestViewService)
        {
            this.requestViewService = requestViewService;
            this.authViewService = authViewService;
            this.userViewService = userViewService;
            this.acceptedRequestViewService = acceptedRequestViewService;
        }

        public IActionResult AcceptConfirmation(RequestViewModel model)
        {
            return View(model);
        }

        public async Task<IActionResult> AcceptRequest(int reqId)
        {
            var user = authViewService.GetCurrentUser();
            var req = await requestViewService.GetRequestByRequestIdAsync(reqId);

            AcceptedRequestViewModel acceptedModel = new AcceptedRequestViewModel();
            acceptedModel.RequestId = req.Id;
            acceptedModel.UserId = user.Id;
            acceptedModel.Date = DateTime.Now;
            var addAcceptedResult = await acceptedRequestViewService.AddAcceptedRequestAsync(acceptedModel);
            if (addAcceptedResult)
            {
                return RedirectToAction("AcceptConfirmation", "Request", req);
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> CreateRequest()
        {
            if (authViewService.GetCurrentUser().isAdmin)
            {
                RequestViewModel model = new RequestViewModel();
                await AddUserSelectListItems(model);
                return View(model);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRequest(RequestViewModel model)
        {
            var user = authViewService.GetCurrentUser();
            if (user.isAdmin)
            {
                model.UserId = model.User.Id;
                model.Date = DateTime.Now;
                model.User = null;
                var result = await requestViewService.AddRequestAsync(model);
                if (result)
                {
                    return RedirectToAction("RequestSubmissionConfirmation", "Request", model); //how to pass requestId?
                }
            }
            else
            {
                model.UserId = user.Id;
                model.Date = DateTime.Now;
                var result = await requestViewService.AddRequestAsync(model);
                if (result)
                {
                    return RedirectToAction("RequestSubmissionConfirmation", "Request", model); //how to pass requestId?
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult DeleteRequest(int reqId)
        {
            var req = requestViewService.GetRequestByRequestIdAsync(reqId).Result;
            return View(req);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteRequest(RequestViewModel model, int reqId)
        {
            model.Id = reqId;
            var result = await requestViewService.DeleteRequestAsync(model);
            if (result)
            {
                TempData["DeleteSuccessful"] = "Your request was successfully deleted!";
                return RedirectToAction("ViewMyRequests", "Request");
            }
            return View(model);
        }

        public IActionResult EditRequest(int reqId)
        {
            var req = requestViewService.GetRequestByRequestIdAsync(reqId).Result;
            return View(req);
        }

        [HttpPost]
        public async Task<IActionResult> EditRequest(RequestViewModel model, int reqId)
        {
            model.Id = reqId;
            var result = await requestViewService.UpdateRequestAsync(model);
            if (result)
            {
                return RedirectToAction("ViewMyRequests", "Request");
            }
            return View(model);
        }

        public async Task<IActionResult> RequestDetails(int reqId)
        {
            var req = await requestViewService.GetRequestByRequestIdAsync(reqId);
            return View(req);
        }

        public IActionResult RequestSubmissionConfirmation(RequestViewModel model)
        {
            return View(model);
        }

        public async Task<IActionResult> ViewMyRequests()
        {
            var user = authViewService.GetCurrentUser();
            var reqs = await requestViewService.GetRequestsByUserIdAsync(user.Id);
            return View(reqs);
        }

        public async Task<IActionResult> ViewRequests()
        {
            var user = authViewService.GetCurrentUser();
            if (user.isAdmin)
            {
                var allReqs = await requestViewService.GetAllRequestsAsync();
                return View(allReqs);
            }
            var reqs = await requestViewService.GetOtherUsersRequestsNotAcceptedAsync(user.Id);
            return View(reqs);
        }

        private async Task<RequestViewModel> AddUserSelectListItems(RequestViewModel model)
        {
            var currentUser = authViewService.GetCurrentUser();
            var result = await userViewService.GetAllUsersAsync();
            foreach (var user in result)
            {
                if (user.Id != currentUser.Id && !user.isAdmin)
                {
                    model.ListUsers(user.LastName, user.Id);
                }
            }
            return model;
        }
    }
}

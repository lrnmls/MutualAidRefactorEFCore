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
        private readonly IAuthViewService authViewService;

        public RequestController(IRequestViewService requestViewService, IAuthViewService authViewService)
        {
            this.requestViewService = requestViewService;
            this.authViewService = authViewService;
        }

        public IActionResult CreateRequest()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRequest(RequestViewModel model)
        {
            model.UserId = authViewService.GetCurrentUser().Id;
            model.Date = DateTime.Now;
            var result = await requestViewService.AddRequestAsync(model);
            if (result)
            {
                return RedirectToAction("RequestSubmissionConfirmation", "UserRequest", model); //how to pass requestId?
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
                return RedirectToAction("ViewMyRequests", "UserRequest");
            }
            return View(model);
        }

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
                return RedirectToAction("ViewMyRequests", "UserRequest");
            }
            return View(model);
        }

        public async Task<IActionResult> RequestDetails(int reqId)
        {
            var req = await requestViewService.GetRequestByRequestIdAsync(reqId);
            return View(req);
        }
    }
}

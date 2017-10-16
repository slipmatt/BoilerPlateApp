﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FrontEndBoilerPlate.Helpers.ReturnsHelper;
using FrontEndBoilerPlate.Helpers.ToastHelper;

namespace FrontEndBoilerPlate.Controllers
{
    public class BaseController : Controller
    {
        public Toastr _toastr;

        public BaseController()
        {
            _toastr = new Toastr();
        }

        public void Success(string title, string message)
        {
            _toastr.AddToastMessage(title, message, ToastType.Success);
            TempData["Toastr"] = _toastr;
        }

        public void Information(string title, string message)
        {
            _toastr.AddToastMessage(title, message, ToastType.Info);
            TempData["Toastr"] = _toastr;
        }

        public void Warning(string title, string message)
        {
            _toastr.AddToastMessage(title, message, ToastType.Warning);
            TempData["Toastr"] = _toastr;
        }

        public void Error(string title, string message)
        {
            _toastr.AddToastMessage(title, message, ToastType.Error);
            TempData["Toastr"] = _toastr;
        }

        protected internal virtual JsonNetResult JsonNetResult()
        {
            return new JsonNetResult();
        }

        protected internal virtual JsonNetResult JsonNetResult(object data)
        {
            return new JsonNetResult(data);
        }
    }
}
﻿using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using MPAPhoneProject.Controllers;

namespace MPAPhoneProject.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : MPAPhoneProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}

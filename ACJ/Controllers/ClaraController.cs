﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ACJ.Controllers
{
    public class ClaraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

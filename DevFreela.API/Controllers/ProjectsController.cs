﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.API.Controllers
{

    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {

        [HttpGet]
        public ActionResult Get()
        {
            return Ok();
        }
    }
}

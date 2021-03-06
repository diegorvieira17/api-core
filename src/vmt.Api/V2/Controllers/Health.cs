﻿using Microsoft.AspNetCore.Mvc;
using vmt.Api.Controllers;
using vmt.Business.Interfaces;

namespace vmt.Api.V2.Controllers
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/health")]
    public class Health : MainController
    {
        public Health(INotificador notificador, IUser appUser) : base(notificador, appUser)
        {
        }

        [HttpGet]
        public ActionResult HealthTest()
        {
            return Ok("V2 - Ok");
        }
    }
}

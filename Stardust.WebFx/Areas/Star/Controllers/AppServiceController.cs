﻿using NewLife.Cube;
using Stardust.Data;

namespace Stardust.Web.Areas.Star.Controllers
{
    public class AppServiceController : EntityController<AppService>
    {
        static AppServiceController()
        {
            MenuOrder = 75;
        }
    }
}
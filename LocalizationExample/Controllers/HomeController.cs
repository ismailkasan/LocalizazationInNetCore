using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocalizationExample.Resources;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace LocalizationExample.Controllers
{
    [ApiController]
    [Route("{culture:culture}/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IStringLocalizer<Resource> Localizer;
        public HomeController(IStringLocalizer<Resource> stringLocalizer)
        {
            this.Localizer = stringLocalizer;
        }
       
        public string Get()
        {
            return Localizer["Home"];
        }
    }
}

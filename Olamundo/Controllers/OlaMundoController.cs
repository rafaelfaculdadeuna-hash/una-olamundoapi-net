using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace Olamundo.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("[controller]")]
    public class OlamundoController : ControllerBase
    {
        public string Get()
        {
            return "Ola mundo!";
        }
    }
}
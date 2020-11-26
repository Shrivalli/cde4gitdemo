using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CDE4github.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [Route("getallnames")]
        public List<string> getnames()
        {
            List<string> names = new List<string>();
            names.Add("Raghav");
            names.Add("Reena");
            names.Add("Vandhana");
            names.Add("Wasim");
            names.Add("Radha");
            return names;
        }
    }
}

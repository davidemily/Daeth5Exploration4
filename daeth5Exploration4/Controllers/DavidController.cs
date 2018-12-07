using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using daeth5Exploration4.Services;
using Microsoft.AspNetCore.Mvc;

namespace daeth5Exploration4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DavidController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            ExplorationService explorationService = new ExplorationService();
            var result = explorationService.GetName();
            if (result != null)
            {
                return result;
            }

            return BadRequest();
        }
    }

}

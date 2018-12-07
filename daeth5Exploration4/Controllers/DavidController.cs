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
        public ActionResult<IEnumerable<string>> Get()
        {
            ExplorationService explorationService = new ExplorationService();
            return new string[]
            {
                explorationService.GetName() , 
                explorationService.GetExploration()
            };
        }

        //PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(string name)
        {
            Console.Write("Service called\n");
            ExplorationService  explorationService= new ExplorationService();
            return explorationService.NewEntry(name);
        }

    }

}

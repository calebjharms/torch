using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using torch.infrastructure.States;
using torch.services.Interfaces;




// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace torch.api.Controllers
{

    [Route("v1/[controller]")]
    public class StateController : Controller
    {

        public readonly IStateService _stateService;
        public StateController(IStateService stateService)
        {
            _stateService = stateService;
        }

        [HttpGet]
        public List<StateDetail> Get()
        {
            List<StateDetail> a = _stateService.GetStates();

            return a;
        }
    }
}

using System;
using torch.infrastructure.States;
using torch.database.Models;
using torch.services.Interfaces;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace torch.services.Services
{
    public class StateService : BaseService, IStateService 
    {
        public StateService(ILogger<StateService> logger, TorchContext context) : base(logger, context)
        {

        }

        public List<StateDetail> GetStates()
        {
            List<State> StatesList = _context.States.ToList();

            List<StateDetail> x = new List<StateDetail>();

            foreach (State d in StatesList)
            {
                StateDetail josh = new StateDetail();

                josh.id = d.id;

                josh.name = d.name;

                josh.code = d.code;

                x.Add(josh);
            }

            return x;
        }
    }
}

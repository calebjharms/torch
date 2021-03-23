using System;
using torch.infrastructure.States;
using System.Collections.Generic;


namespace torch.services.Interfaces 
{
    public interface IStateService
    {
        List<StateDetail> GetStates(); 

    }
}

using System;
using System.Collections.Generic;
using torch.infrastructure.Organizations;




namespace torch.services.Interfaces
{
    public interface IOrganizationService
    {
        Guid CreateOrganization(OrganizationCreate organization);

        List<OrganizationDetail> GetOrganizations();

        OrganizationDetail GetOrganization(Guid id);
    }
}

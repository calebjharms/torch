using System;
using torch.infrastructure.Organizations;




namespace torch.services.Interfaces
{
    public interface IOrganizationService
    {
        Guid CreateOrganization(OrganizationCreate organization);

        OrganizationDetail GetOrganization(Guid id);
    }
}

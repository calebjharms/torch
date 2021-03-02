using System;
using System.Linq;
using Microsoft.Extensions.Logging;
using torch.database.Models;
using torch.infrastructure.Organizations;
using torch.services.Interfaces;


namespace torch.services.Services 
{
    public class OrganizationService : BaseService, IOrganizationService
    {
        public OrganizationService(ILogger<OrganizationService> logger, TorchContext context) : base(logger, context)
        {

        }

        public Guid CreateOrganization(OrganizationCreate organization)
        {
            Organization newOrganization = new Organization();

            newOrganization.id = Guid.NewGuid();

            newOrganization.active = organization.active;

            newOrganization.name = organization.name;

            newOrganization.email = organization.email;

            newOrganization.address = organization.address;

            newOrganization.address2 = organization.address2;

            newOrganization.stateId = organization.stateId;

            _context.Organizations.Add(newOrganization);

            _context.SaveChanges();

            return newOrganization.id;
        }

        public OrganizationDetail GetOrganization(Guid id)
        {
            Organization organization = _context.Organizations.Where(x => x.id == id).FirstOrDefault();

            if (organization != null)
            {
                OrganizationDetail organizationDetail = new OrganizationDetail();

                organizationDetail.id = organization.id;

                organizationDetail.active = organization.active;

                organizationDetail.name = organization.name;

                organizationDetail.email = organization.email;

                organizationDetail.address = organization.address;

                organizationDetail.address2 = organization.address2;

                organizationDetail.stateId = organization.stateId;

                return organizationDetail;
            }

            throw new Exception($"ID {id} does not exist in database");

        }
    }
}

using System;
using System.Collections.Generic;
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

            newOrganization.phone = organization.phone;

            newOrganization.address = organization.address;

            newOrganization.address2 = organization.address2;

            newOrganization.city = organization.city;

            newOrganization.stateId = organization.stateId;

            newOrganization.zip = organization.zip;

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

                organizationDetail.phone = organization.phone;

                organizationDetail.address = organization.address;

                organizationDetail.address2 = organization.address2;

                organizationDetail.city = organization.city;

                organizationDetail.stateId = organization.stateId;

                organizationDetail.zip = organization.zip;

                return organizationDetail;
            }

            throw new Exception($"ID {id} does not exist in database");

        }

        public List<OrganizationDetail> GetOrganizations()
        {
            List<Organization> c = _context.Organizations.ToList();

            List<OrganizationDetail> x = new List<OrganizationDetail>();

            foreach (Organization d in c )
            {
                OrganizationDetail josh = new OrganizationDetail();

                josh.id = d.id;

                josh.name = d.name;

                josh.email = d.email;

                josh.active = d.active;

                x.Add(josh);
            }

            return x;

        }
    }
}

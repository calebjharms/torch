using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using torch.infrastructure.Organizations;
using torch.services.Interfaces;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace torch.api.Controllers
{
    [Route("v1/[controller]")]
    public class OrganizationController : Controller
    {
        public readonly IOrganizationService _organization;

        public OrganizationController(IOrganizationService organization)
        {
            _organization = organization;
        }

        [HttpGet("all")]
        public List<OrganizationDetail> Get()
        {
            List<OrganizationDetail> a = _organization.GetOrganizations();

            return a;
        }

        [HttpGet("{id}")]
        public OrganizationDetail Get(Guid id)
        {
            OrganizationDetail a = _organization.GetOrganization(id);

            return a;
        }

        [HttpPost]
        public Guid Post (OrganizationCreate b)
        {
            Guid id = _organization.CreateOrganization(b);

            return id;
        }
    }
}

using System;
namespace torch.infrastructure.Organizations
{
    public class OrganizationDetail
    {
        public Guid id { get; set; }

        public bool active { get; set; }

        public string name { get; set; }

        public string email { get; set; }

        public string address { get; set; }

        public string address2 { get; set; }

        public int? stateId { get; set; }
    }
}

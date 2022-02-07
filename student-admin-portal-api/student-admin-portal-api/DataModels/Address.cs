using System;

namespace student_admin_portal_api.DataModels
{
    public class Address
    {
        public Guid Id { get; set; }
        public string PhysicalAddress { get; set; }
        public string PostalAddress { get; set; }

        // Nav prop
        public Guid StudentId { get; set; }
    }
}

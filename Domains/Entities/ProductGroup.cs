using System;

namespace Domains.Entities
{
    public class ProductGroup
    {
        public int Id { get; set; }
        public string GroupDescription { get; set; }
        public string GroupCode { get; set; }
        public bool IsActive { get; set; }
        public DateTime WhenEntered { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? WhenModified { get; set; }
    }
}

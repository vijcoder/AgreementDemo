using System;
using System.Collections.Generic;
using System.Text;

namespace Domains.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int ProductGroupId { get; set; }
        public string ProductDescription { get; set; }
        public string ProductNumber { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public DateTime WhenEntered { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? WhenModified { get; set; }
    }
}

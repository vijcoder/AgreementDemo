using Domains.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domains.ViewModels
{
    public class AgreementViewModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int ProductGroupId { get; set; }
        public string GroupDescription { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal NewPrice { get; set; }
        public bool IsActive { get; set; }
        public DateTime? WhenEntered { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? WhenModified { get; set; }

        public IEnumerable<ProductGroup> ProductGroupList { get; set; }
        public IEnumerable<Product> ProductList { get; set; }

    }
}

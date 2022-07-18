using System;

namespace Domains.Entities
{
    public class Agreement
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int ProductGroupId { get; set; }
        public int ProductId { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal NewPrice { get; set; }
        public bool IsActive { get; set; }
        public DateTime? WhenEntered { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? WhenModified { get; set; }


    }
}

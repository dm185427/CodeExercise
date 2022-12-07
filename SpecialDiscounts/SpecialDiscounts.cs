
using System;

namespace Retalix.StoreServices.Connectivity.Infrastructure.SpecialDiscounts
{
    [Serializable]
    public class SpecialDiscounts : ISpecialDiscounts
    {
        public SpecialDiscounts() { }
        public virtual int Id { get; set; }
        public virtual string DiscountCode { get; set; }
        public virtual int Value { get; set; }
        public virtual string ExpiryDate { get; set; }
    }
}

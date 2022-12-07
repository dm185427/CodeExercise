using Retalix.StoreServices.Model.Infrastructure.DataMovement;
using Retalix.StoreServices.Model.Infrastructure.Security.Identity;

namespace Retalix.StoreServices.Connectivity.Infrastructure.SpecialDiscounts
{
    public interface ISpecialDiscounts 
    {
        int  Id { get; set; }
        string DiscountCode { get; set; }
        int Value { get; set; }
        string ExpiryDate { get; set; }
    }
}

using Retalix.Contracts.Generated.SpecialDiscounts;
using Retalix.StoreServices.Connectivity.Infrastructure.SpecialDiscounts;
using Retalix.StoreServices.Model.Infrastructure.Service;

namespace Retalix.StoreServices.BusinessServices.FrontEnd.SpecialDiscounts
{
    public class SpecialDiscountsMapper : IMapper<SpecialDiscountsType, ISpecialDiscounts>, IMapper<ISpecialDiscounts, ISpecialDiscounts>
    {

        public void Map(SpecialDiscountsType source, ISpecialDiscounts target, IMappingContext context)
        {
            target.Id = source.Id;
            target.DiscountCode = source.DiscountCode;
            target.Value = source.Value;
            target.ExpiryDate = source.ExpiryDate;
        }

        public void Map(ISpecialDiscounts source, ISpecialDiscounts target, IMappingContext context)
        {
            target.Id = source.Id;
            target.DiscountCode = source.DiscountCode;
            target.Value = source.Value;
            target.ExpiryDate = source.ExpiryDate;
        }
    }
}

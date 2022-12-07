using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retalix.StoreServices.Connectivity.Infrastructure.SpecialDiscounts
{
    public interface ISpecialDiscountsDao
    {
        ISpecialDiscounts Get(string id);
        ISpecialDiscounts Find(string DiscountCOde);
        void Save(ISpecialDiscounts specialDiscounts);
        void Delete(ISpecialDiscounts specialDiscounts);
        IList<ISpecialDiscounts> GetAll();
    }
}

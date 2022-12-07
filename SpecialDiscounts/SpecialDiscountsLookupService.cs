using Retalix.Contracts.Generated.Common;
using Retalix.Contracts.Generated.SpecialDiscounts;
using Retalix.DPOS.SystemIntegrity;
using Retalix.StoreServices.BusinessServices.Common.Services;
using Retalix.StoreServices.Connectivity.Infrastructure.SpecialDiscounts;
using Retalix.StoreServices.Model.Infrastructure.Service;
using Retalix.StoreServices.Connectivity.Infrastructure.SpecialDiscounts;
using System;
using System.Collections.Generic;
using Retalix.StoreServices.Infrastructure.DataAccess;
using System.Linq;

namespace Retalix.StoreServices.BusinessServices.FrontEnd.SpecialDiscounts
{
    [LookupService(typeof(SpecialDiscountsLookupRequest), typeof(SpecialDiscountsLookupResponse), Version = "1.0.0")]
    public class SpecialDiscountsLookupService
    {
        private readonly ISpecialDiscountsDao _specialDiscountsDao;
        //private readonly IBusinessUnitDao _businessUnitDao;
        //private readonly IRetailSegmentDao _retailSegmentDao;
        //private readonly IBusinessConfigurationMaintenanceRequestValidator _businessConfigurationMaintenanceRequestValidator;
        private readonly IMapper _mapper;
        public SpecialDiscountsLookupService(IMapper mapper, ISpecialDiscountsDao specialDiscountsDao)
        {
            _specialDiscountsDao = specialDiscountsDao;
            _mapper = mapper;
        }
        public SpecialDiscountsLookupResponse Lookup(string discountCode)
        {
            var discounts = _specialDiscountsDao.GetAll();
            return new SpecialDiscountsLookupResponse
            {
                SpecialDiscountsType = _mapper.MapCollection<SpecialDiscountsType>(discounts).ToArray()
            };
        }
    }
}

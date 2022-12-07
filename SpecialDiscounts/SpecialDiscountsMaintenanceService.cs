using Retalix.Contracts.Generated.Common;
using Retalix.Contracts.Generated.SpecialDiscounts;
using Retalix.DPOS.SystemIntegrity;
using Retalix.StoreServices.BusinessServices.Common.Services;
using Retalix.StoreServices.Connectivity.Infrastructure.SpecialDiscounts;
using Retalix.StoreServices.Model.Infrastructure.Service;
using Retalix.StoreServices.Connectivity.Infrastructure.SpecialDiscounts;
using System;

namespace Retalix.StoreServices.BusinessServices.FrontEnd.SpecialDiscounts
{
    public class SpecialDiscountsMaintenanceService : BusinessServiceBase<SpecialDiscountsMaintenanceRequest, SpecialDiscountsMaintenanceResponse>
    {
        private readonly ISpecialDiscountsDao _specialDiscountsDao;
        //private readonly IBusinessUnitDao _businessUnitDao;
        //private readonly IRetailSegmentDao _retailSegmentDao;
        //private readonly IBusinessConfigurationMaintenanceRequestValidator _businessConfigurationMaintenanceRequestValidator;
        private readonly IMapper _mapper;
        public string MessageId { get { return Request.Header.MessageId.Value; } }
        public SpecialDiscountsMaintenanceService(IMapper mapper, ISpecialDiscountsDao specialDiscountsDao)
        {
            _specialDiscountsDao = specialDiscountsDao;
            _mapper = mapper;
        }
        protected override SpecialDiscountsMaintenanceResponse InternalExecute()
        {
            if (Request == null || Request.SpecialDiscountsType == null) return null;
            var action = GetAction(Request);
            if (action == ActionTypeCodes.Add)
            {
                var mappedLink = _mapper.Map<ISpecialDiscounts>(Request.SpecialDiscountsType);
                AddOrUpdate(mappedLink);
            }
            return CreateResponse();
        }
        private void AddOrUpdate(ISpecialDiscounts discounts)
        {
            try
            {
                var existing = _specialDiscountsDao.Find(discounts.DiscountCode);
                if (existing == null)
                {
                    _specialDiscountsDao.Save(discounts);
                }
            }
            catch (Exception ex)
            {
                //AddBusinessError(ex, requestType.Sequence);
            }
        }
        private ActionTypeCodes GetAction(SpecialDiscountsMaintenanceRequest request)
        {
            return request.SpecialDiscountsType.ActionSpecified ? request.SpecialDiscountsType.Action : ActionTypeCodes.AddOrUpdate;
        }
        private void DeleteComboItem(ISpecialDiscounts specialDiscounts)
        {
            _specialDiscountsDao.Delete(specialDiscounts);
        }
        private static SpecialDiscountsMaintenanceResponse CreateResponse()
        {
            return new SpecialDiscountsMaintenanceResponse
            {
                Header = new RetalixCommonHeaderType()
            };
        }
        public ISpecialDiscounts CreateDiscountItem(SpecialDiscountsType specialDiscounttypes)
        {
            var discounts = new Retalix.StoreServices.Connectivity.Infrastructure.SpecialDiscounts.SpecialDiscounts();
            //_mapper.Map(specialDiscounttypes, discounts, null);
            return null;
        }
        private SpecialDiscountsMaintenanceResponse BuildResponse()
        {
            return new SpecialDiscountsMaintenanceResponse
            {
                Header = new RetalixCommonHeaderType
                {
                    Response = new RetalixResponseCommonData
                    {
                        ResponseCode = "OK",
                        RequestID = MessageId,
                        ResponseTimestamp = DateTimeService.Instance.Now,
                    }
                }
            };
        }

        public override IDocumentResponse FormatErrorResponse(IDocumentRequest request, Exception exception)
        {
            var returnResponse = new SpecialDiscountsMaintenanceResponse
            {
                Header = new RetalixCommonHeaderType
                {
                    Response = new RetalixResponseCommonData
                    {
                        ResponseCode = "Rejected",
                        BusinessError = null//GetContractBusinessError(exception)
                    }
                }
            };

            return new DocumentResponse(returnResponse);
        }
    }
}

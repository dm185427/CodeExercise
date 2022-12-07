using NHibernate;
using Retalix.StoreServices.Connectivity.Infrastructure.Application;
using Retalix.StoreServices.Infrastructure.DataAccess;
using Retalix.StoreServices.Model.Infrastructure.DataAccess;
using Retalix.StoreServices.Model.Infrastructure.Security.Identity;
using Retalix.StoreServices.Model.Infrastructure.Service;
using System.Collections.Generic;
using ISession = NHibernate.ISession;

namespace Retalix.StoreServices.Connectivity.Infrastructure.SpecialDiscounts
{
    public class SpecialDiscountsDao : ISpecialDiscountsDao
    {
        private readonly ISessionProvider _sessionProvider;
        private readonly IFactory _factory;
        public SpecialDiscountsDao(ISessionProvider sessionProvider, IFactory factory)
        {
            _sessionProvider = sessionProvider;
            _factory = factory;
        }
        private ISession Session
        {
            get { return _sessionProvider.GetDefaultSession<ISession>(); }
        }
        public ISpecialDiscounts Get(string id)
        {
            var application = Session.Get<ISpecialDiscounts>(id);
            if (application == null)
                throw new ApplicationNotFoundException(id);

            return application;
        }

        public ISpecialDiscounts Find(string DiscountCode)
        {
            var query = Session.QueryOver<ISpecialDiscounts>().Where(u => u.DiscountCode == DiscountCode);
            return query.SingleOrDefault();
        }
        public IList<ISpecialDiscounts> GetAll()
        {
            var allSpecialDiscounts = Session.CreateCriteria<ISpecialDiscounts>().List<ISpecialDiscounts>();
            return allSpecialDiscounts;
        }

        public void Save(ISpecialDiscounts specialDiscounts)
        {
            Session.Save(specialDiscounts);
        }

        public void Delete(ISpecialDiscounts specialDiscounts)
        {
            Session.Delete(specialDiscounts);
        }

        public string Name
        {
            get { return "Special Discounts"; }
        }
    }
}

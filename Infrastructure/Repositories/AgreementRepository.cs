using Domains.Entities;
using Domains.Repositories;
using Domains.ViewModels;
using Infrastructure.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class AgreementRepository : IAgreementRepository
    {
        private readonly ApplicationDbContext dbContext;
        public AgreementRepository(ApplicationDbContext context)
        {
            dbContext = context;
        }
        public IList<ProductGroup> GetProductGroup()
        {
            return dbContext.ProductGroup.ToList();
        }
        public IList<Product> GetProduct()
        {
            return dbContext.Product.ToList();
        }
        public IList<AgreementViewModel> GetAgreements()
        {
            var data = (from a in dbContext.Agreement
                        join b in dbContext.ProductGroup on a.ProductGroupId equals b.Id
                        join c in dbContext.Product on a.ProductId equals c.Id
                        select new AgreementViewModel
                        {
                            Id = a.Id,
                            GroupDescription = b.GroupDescription,
                            ProductDescription = c.ProductDescription,
                            UserId = a.UserId,
                            ProductGroupId = a.ProductGroupId,
                            ProductId = a.ProductId,
                            EffectiveDate = a.EffectiveDate,
                            ExpirationDate = a.ExpirationDate,
                            ProductPrice = a.ProductPrice,
                            NewPrice = a.NewPrice,
                            IsActive = a.IsActive,
                            WhenEntered = a.WhenEntered
                        }).ToList();
            return data;

            //return dbContext.Agreement.ToList();
        }
        public async Task<Agreement> GetById(int id)
        {
            return await dbContext.Agreement.FindAsync(id);
        }
        public async Task<bool> Insert(Agreement model)
        {
            dbContext.Agreement.Add(model);
            int result = await dbContext.SaveChangesAsync();
            if (result > 0)
                return true;
            else
                return false;
        }
        public async Task<bool> Update(Agreement model)
        {
            dbContext.Agreement.Update(model);
            int result = await dbContext.SaveChangesAsync();
            if (result > 0)
                return true;
            else
                return false;
        }
        public async Task Remove(Agreement model)
        {
            dbContext.Agreement.Remove(model);
            await dbContext.SaveChangesAsync();
        }
    }
}

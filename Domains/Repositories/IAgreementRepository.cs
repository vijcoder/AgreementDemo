using Domains.Entities;
using Domains.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domains.Repositories
{
    public interface IAgreementRepository
    {
        IList<AgreementViewModel> GetAgreements();

        Task<Agreement> GetById(int id);
        Task<bool> Insert(Agreement model);
        Task<bool> Update(Agreement model);

        IList<ProductGroup> GetProductGroup();

        IList<Product> GetProduct();

        Task Remove(Agreement model);
    }
}

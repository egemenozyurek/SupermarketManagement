using CoreBusiness;
using System.Collections.Generic;

namespace UseCases.DataStorePluginInterfaces
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> GetCategories();
    }
}

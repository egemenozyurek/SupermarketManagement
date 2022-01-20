using CoreBusiness;
using System.Collections.Generic;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class ViewProductsByCategoryId : IViewProductsByCategoryId
    {
        private readonly IProductRepository productRepository;

        public ViewProductsByCategoryId(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IEnumerable<Product> Execute(int categoryId)
        {
            return productRepository.GetProductsByCategoryId(categoryId);
        }
    }
}

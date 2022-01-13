using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class EditProductUseCase : IEditProductUseCase
    {
        private readonly IProductRepository productRepository;

        public EditProductUseCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public void Execute(Product product)
        {
            productRepository.UpdateProduct(product);
        }
    }
}

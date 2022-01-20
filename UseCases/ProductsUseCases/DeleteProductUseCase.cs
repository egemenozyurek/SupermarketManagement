using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class DeleteProductUseCase : IDeleteProductUseCase
    {
        private readonly IProductRepository productRepository;

        public DeleteProductUseCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public void Execute(int productId)
        {
            productRepository.DeleteProduct(productId);
        }
    }
}

using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class SellProductUseCase : ISellProductUseCase
    {
        private readonly IProductRepository productRepository;

        public SellProductUseCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public void Execute(int productId, int qtyToSell)
        {
            var product = productRepository.GetProductById(productId);
            if (product == null) return;

            product.Quantity -= qtyToSell;
            productRepository.UpdateProduct(product);
        }
    }
}

namespace UseCases
{
    public interface ISellProductUseCase
    {
        void Execute(int productId, int qtyToSell);
    }
}
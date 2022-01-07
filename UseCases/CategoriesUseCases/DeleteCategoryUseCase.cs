using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class DeleteCategoryUseCase : IDeleteCategoryUseCase
    {
        private readonly ICategoryRepository categoryRepository;

        public DeleteCategoryUseCase(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public void Delete(int categoryId)
        {
            categoryRepository.DeleteCategory(categoryId);
        }
    }
}

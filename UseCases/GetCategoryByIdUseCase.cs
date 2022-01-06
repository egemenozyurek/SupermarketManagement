using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class GetCategoryByIdUseCase : IGetCategoryByIdUseCase
    {
        private readonly ICategoryRepository categoryRepository;

        public GetCategoryByIdUseCase(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public Category Execute(int categoryId)
        {
            return categoryRepository.GetCategoryById(categoryId);
        }
    }
}

using SignalRWebUI.BusinessLayer.Dtos.Requests.Category;
using SignalRWebUI.BusinessLayer.Dtos.Responses.Category;

namespace SignalRWebUI.BusinessLayer.Abstracts;

public interface ICategoryService
{
    Task<List<GetCategoryResponse>> GetListAsync();
    Task<GetCategoryResponse> GetAsync(GetCategoryRequest getCategoryRequest);
    Task<CreatedCategoryResponse> AddAsync(CreateCategoryRequest createCategoryRequest);
    Task<UpdatedCategoryResponse> UpdateAsync(int id, UpdateCategoryRequest updateCategoryRequest);
    Task<DeletedCategoryResponse> DeleteAsync(DeleteCategoryRequest deleteCategoryRequest);
}



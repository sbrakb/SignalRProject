using AutoMapper;
using SignalIR.EntityLayer.Entities;
using SignalR.BusinessLayer.Abstracts;
using SignalR.BusinessLayer.Dtos.Requests.Category;
using SignalR.BusinessLayer.Dtos.Responses.Category;
using SignalR.DataAccessLayer.Abstracts;

namespace SignalR.BusinessLayer.Concretes;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryDal;
    private readonly IMapper _mapper;
    public CategoryManager(ICategoryDal categoryDal, IMapper mapper)
    {
        _categoryDal = categoryDal;
        _mapper = mapper;
    }

    public async Task<CreatedCategoryResponse> AddAsync(CreateCategoryRequest createCategoryRequest)
    {
        Category category = _mapper.Map<Category>(createCategoryRequest);
        await _categoryDal.AddAsync(category);
        CreatedCategoryResponse createdCategoryResponse = _mapper.Map<CreatedCategoryResponse>(category);
        return createdCategoryResponse;

    }

    public async Task<DeletedCategoryResponse> DeleteAsync(DeleteCategoryRequest deleteCategoryRequest)
    {
        Category category = await _categoryDal.GetAsync(deleteCategoryRequest.Id);
        await _categoryDal.DeleteAsync(category);
        DeletedCategoryResponse deletedCategoryResponse = _mapper.Map<DeletedCategoryResponse>(category);
        return deletedCategoryResponse;
    }

    public async Task<GetCategoryResponse> GetAsync(GetCategoryRequest getCategoryRequest)
    {
        Category category = await _categoryDal.GetAsync(getCategoryRequest.Id);
        GetCategoryResponse getCategoryResponse = _mapper.Map<GetCategoryResponse>(category);
        return getCategoryResponse;
    }

    public async Task<List<GetCategoryResponse>> GetListAsync()
    {
        List<Category> categories = await _categoryDal.GetListAsync();
        List<GetCategoryResponse> getCategoryResponses  = _mapper.Map<List<GetCategoryResponse>>(categories);
        return getCategoryResponses;
    }

    public async Task<UpdatedCategoryResponse> UpdateAsync(int id, UpdateCategoryRequest updateCategoryRequest)
    {
        Category category = await _categoryDal.GetAsync(id);
        _mapper.Map(updateCategoryRequest, category);
        await _categoryDal.UpdateAsync(category);
        UpdatedCategoryResponse updatedCategoryResponse = _mapper.Map<UpdatedCategoryResponse>(category);
        return updatedCategoryResponse;
    }
}
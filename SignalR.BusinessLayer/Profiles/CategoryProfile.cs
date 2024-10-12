using AutoMapper;
using SignalIR.EntityLayer.Entities;
using SignalRWebUI.BusinessLayer.Dtos.Requests.Category;
using SignalRWebUI.BusinessLayer.Dtos.Responses.Category;

namespace SignalRWebUI.BusinessLayer.Profiles;

public class CategoryProfile:Profile
{
    public CategoryProfile()
    {
        CreateMap<CreateCategoryRequest, Category>().ReverseMap();
        CreateMap<Category, CreatedCategoryResponse>().ReverseMap();

        CreateMap<Category, DeletedCategoryResponse>().ReverseMap();

        CreateMap<Category, GetCategoryResponse>().ReverseMap();

        CreateMap<UpdateCategoryRequest, Category>().ReverseMap();
        CreateMap<Category, UpdatedCategoryResponse>().ReverseMap();
    }
}

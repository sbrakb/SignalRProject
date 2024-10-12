using AutoMapper;
using SignalIR.EntityLayer.Entities;
using SignalRWebUI.BusinessLayer.Dtos.Requests.Product;
using SignalRWebUI.BusinessLayer.Dtos.Responses.Product;

namespace SignalRWebUI.BusinessLayer.Profiles;

public class ProductProfile : Profile
{
	public ProductProfile()
	{
		CreateMap<CreateProductRequest, Product>().ReverseMap();
		CreateMap<Product, CreatedProductResponse>().ReverseMap();

		CreateMap<Product, DeletedProductResponse>().ReverseMap();

		CreateMap<Product, GetProductResponse>().ReverseMap();

		CreateMap<UpdateProductRequest, Product>().ReverseMap();
		CreateMap<Product, UpdatedProductResponse>().ReverseMap();

		CreateMap<Product, GetProductWithCategoryNameResponse>()
			.ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
			.ReverseMap();
	}
}

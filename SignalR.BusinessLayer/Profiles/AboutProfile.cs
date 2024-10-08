using AutoMapper;
using SignalIR.EntityLayer.Entities;
using SignalR.BusinessLayer.Dtos.Requests.About;
using SignalR.BusinessLayer.Dtos.Responses.About;

namespace SignalR.BusinessLayer.Profiles;

public class AboutProfile:Profile
{
	public AboutProfile()
	{
		CreateMap<CreateAboutRequest,About>().ReverseMap();
		CreateMap<About, CreatedAboutResponse>().ReverseMap();

		CreateMap<DeleteAboutRequest, About>().ReverseMap();
		CreateMap<About, DeletedAboutResponse>().ReverseMap();

		CreateMap<About, GetAboutResponse>().ReverseMap();

		CreateMap<UpdateAboutRequest, About>().ReverseMap();
		CreateMap<About,UpdatedAboutResponse>().ReverseMap();
	}
}

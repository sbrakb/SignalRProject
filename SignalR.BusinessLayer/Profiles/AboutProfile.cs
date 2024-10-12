using AutoMapper;
using SignalIR.EntityLayer.Entities;
using SignalRWebUI.BusinessLayer.Dtos.Requests.About;
using SignalRWebUI.BusinessLayer.Dtos.Responses.About;

namespace SignalRWebUI.BusinessLayer.Profiles;

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

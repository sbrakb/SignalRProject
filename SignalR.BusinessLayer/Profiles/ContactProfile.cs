using AutoMapper;
using SignalIR.EntityLayer.Entities;
using SignalRWebUI.BusinessLayer.Dtos.Requests.Contact;
using SignalRWebUI.BusinessLayer.Dtos.Responses.Contact;

namespace SignalRWebUI.BusinessLayer.Profiles;

public class ContactProfile : Profile
{
    public ContactProfile()
    {
        CreateMap<CreateContactRequest, Contact>().ReverseMap();
        CreateMap<Contact, CreatedContactResponse>().ReverseMap();

        CreateMap<Contact, DeletedContactResponse>().ReverseMap();

        CreateMap<Contact, GetContactResponse>().ReverseMap();

        CreateMap<UpdateContactRequest, Contact>().ReverseMap();
        CreateMap<Contact, UpdatedContactResponse>().ReverseMap();
    }
}
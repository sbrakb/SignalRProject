using AutoMapper;
using SignalIR.EntityLayer.Entities;
using SignalR.BusinessLayer.Dtos.Requests.Contact;
using SignalR.BusinessLayer.Dtos.Responses.Contact;

namespace SignalR.BusinessLayer.Profiles;

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
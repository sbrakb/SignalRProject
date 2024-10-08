using AutoMapper;
using SignalIR.EntityLayer.Entities;
using SignalR.BusinessLayer.Abstracts;
using SignalR.BusinessLayer.Dtos.Requests.Contact;
using SignalR.BusinessLayer.Dtos.Responses.Contact;
using SignalR.DataAccessLayer.Abstracts;

namespace SignalR.BusinessLayer.Concretes;

public class ContactManager : IContactService
{
    private readonly IContactDal _contactDal;
    private readonly IMapper _mapper;
    public ContactManager(IContactDal contactDal, IMapper mapper)
    {
        _contactDal = contactDal;
        _mapper = mapper;
    }

    public async Task<CreatedContactResponse> AddAsync(CreateContactRequest createContactRequest)
    {
        Contact contact = _mapper.Map<Contact>(createContactRequest);
        await _contactDal.AddAsync(contact);
        CreatedContactResponse createdContactResponse = _mapper.Map<CreatedContactResponse>(contact);
        return createdContactResponse;
    }

    public async Task<DeletedContactResponse> DeleteAsync(DeleteContactRequest deleteContactRequest)
    {
        Contact contact = await _contactDal.GetAsync(deleteContactRequest.Id);
        await _contactDal.DeleteAsync(contact);
        DeletedContactResponse deletedContactResponse = _mapper.Map<DeletedContactResponse>(contact);
        return deletedContactResponse;
    }

    public async Task<GetContactResponse> GetAsync(GetContactRequest getContactRequest)
    {
        Contact contact = await _contactDal.GetAsync(getContactRequest.Id);
        GetContactResponse getContactResponse = _mapper.Map<GetContactResponse>(contact);
        return getContactResponse;
    }

    public async Task<List<GetContactResponse>> GetListAsync()
    {
        List<Contact> contacts = await _contactDal.GetListAsync();
        List<GetContactResponse> getContactResponses = _mapper.Map<List<GetContactResponse>>(contacts);
        return getContactResponses;
    }

    public async Task<UpdatedContactResponse> UpdateAsync(int id, UpdateContactRequest updateContactRequest)
    {
        Contact contact = await _contactDal.GetAsync(id);
        _mapper.Map(updateContactRequest, contact);
        UpdatedContactResponse updatedContactResponse = _mapper.Map<UpdatedContactResponse>(contact);
        return updatedContactResponse;
    }
}
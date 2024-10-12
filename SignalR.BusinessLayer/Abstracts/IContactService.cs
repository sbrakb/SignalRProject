using SignalRWebUI.BusinessLayer.Dtos.Requests.Contact;
using SignalRWebUI.BusinessLayer.Dtos.Responses.Contact;

namespace SignalRWebUI.BusinessLayer.Abstracts;

public interface IContactService
{
    Task<List<GetContactResponse>> GetListAsync();
    Task<GetContactResponse> GetAsync(GetContactRequest getContactRequest);
    Task<CreatedContactResponse> AddAsync(CreateContactRequest createContactRequest);
    Task<UpdatedContactResponse> UpdateAsync(int id, UpdateContactRequest updateContactRequest);
    Task<DeletedContactResponse> DeleteAsync(DeleteContactRequest deleteContactRequest);
}



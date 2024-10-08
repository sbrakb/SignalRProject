using SignalR.BusinessLayer.Dtos.Requests.Testimoinal;
using SignalR.BusinessLayer.Dtos.Responses.Testimoinal;

namespace SignalR.BusinessLayer.Abstracts;

public interface ITestimoinalService
{
    Task<List<GetTestimoinalResponse>> GetListAsync();
    Task<GetTestimoinalResponse> GetAsync(GetTestimoinalRequest getTestimoinalRequest);
    Task<CreatedTestimoinalResponse> AddAsync(CreateTestimoinalRequest createTestimoinalRequest);
    Task<UpdatedTestimoinalResponse> UpdateAsync(int id, UpdateTestimoinalRequest updateTestimoinalRequest);
    Task<DeletedTestimoinalResponse> DeleteAsync(DeleteTestimoinalRequest deleteTestimoinalRequest);
}



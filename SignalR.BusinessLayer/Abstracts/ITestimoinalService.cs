using SignalRWebUI.BusinessLayer.Dtos.Requests.Testimoinal;
using SignalRWebUI.BusinessLayer.Dtos.Responses.Testimoinal;

namespace SignalRWebUI.BusinessLayer.Abstracts;

public interface ITestimoinalService
{
    Task<List<GetTestimoinalResponse>> GetListAsync();
    Task<GetTestimoinalResponse> GetAsync(GetTestimoinalRequest getTestimoinalRequest);
    Task<CreatedTestimoinalResponse> AddAsync(CreateTestimoinalRequest createTestimoinalRequest);
    Task<UpdatedTestimoinalResponse> UpdateAsync(int id, UpdateTestimoinalRequest updateTestimoinalRequest);
    Task<DeletedTestimoinalResponse> DeleteAsync(DeleteTestimoinalRequest deleteTestimoinalRequest);
}



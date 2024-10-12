using Microsoft.AspNetCore.Mvc;
using SignalRWebUI.BusinessLayer.Abstracts;
using SignalRWebUI.BusinessLayer.Dtos.Requests.Testimoinal;

namespace SignaIRApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TestimoinalsController : ControllerBase
{
    private readonly ITestimoinalService _testimoinalService;

    public TestimoinalsController(ITestimoinalService testimoinalService)
    {
        _testimoinalService = testimoinalService;
    }

    [HttpGet("getall")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _testimoinalService.GetListAsync();
        return Ok(result);
    }

    [HttpGet("getbyid")]
    public async Task<IActionResult> GetById([FromQuery] GetTestimoinalRequest getTestimoinalRequest)
    {
        var result = await _testimoinalService.GetAsync(getTestimoinalRequest);
        return Ok(result);
    }

    [HttpPost("add")]
    public async Task<IActionResult> Add([FromBody] CreateTestimoinalRequest createTestimoinalRequest)
    {
        var result = await _testimoinalService.AddAsync(createTestimoinalRequest);
        return Ok(result);
    }

    [HttpPut("update")]
    public async Task<IActionResult> Update([FromQuery] int id, [FromBody] UpdateTestimoinalRequest updateTestimoinalRequest)
    {
        var result = await _testimoinalService.UpdateAsync(id, updateTestimoinalRequest);
        return Ok(result);
    }

    [HttpDelete("delete")]
    public async Task<IActionResult> Delete([FromQuery] DeleteTestimoinalRequest deleteTestimoinalRequest)
    {
        var result = await _testimoinalService.DeleteAsync(deleteTestimoinalRequest);
        return Ok(result);
    }

}
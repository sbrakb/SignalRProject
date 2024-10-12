using Microsoft.AspNetCore.Mvc;
using SignalRWebUI.BusinessLayer.Abstracts;
using SignalRWebUI.BusinessLayer.Dtos.Requests.About;

namespace SignaIRApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AboutsController : ControllerBase
{
    private readonly IAboutService _aboutService;

    public AboutsController(IAboutService aboutService)
    {
        _aboutService = aboutService;
    }

    [HttpGet("getall")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _aboutService.GetListAsync();
        return Ok(result);
    }

    [HttpGet("getbyid")]
    public async Task<IActionResult> GetById([FromQuery]GetAboutRequest getAboutRequest)
    {
        var result = await _aboutService.GetAsync(getAboutRequest);
        return Ok(result);
    }

    [HttpPost("add")]
    public async Task<IActionResult> Add([FromBody] CreateAboutRequest createAboutRequest)
    {
        var result =await _aboutService.AddAsync(createAboutRequest);
        return Ok(result);
    }

    [HttpPut("update")]
    public async Task<IActionResult> Delete([FromQuery]int id, [FromBody] UpdateAboutRequest updateAboutRequest)
    {
        var result = await _aboutService.UpdateAsync(id, updateAboutRequest);
        return Ok(result);
    }

    [HttpDelete("delete")]
    public async Task<IActionResult> Delete([FromQuery] DeleteAboutRequest deleteAboutRequest)
    {
        var result = await _aboutService.DeleteAsync(deleteAboutRequest);
        return Ok(result);
    }
}

using Microsoft.AspNetCore.Mvc;
using SignalRWebUI.BusinessLayer.Abstracts;
using SignalRWebUI.BusinessLayer.Dtos.Requests.SocialMedia;

namespace SignaIRApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SocialMediasController : ControllerBase
{
    private readonly ISocialMediaService _socialMediaService;

    public SocialMediasController(ISocialMediaService socialMediaService)
    {
        _socialMediaService = socialMediaService;
    }

    [HttpGet("getall")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _socialMediaService.GetListAsync();
        return Ok(result);
    }

    [HttpGet("getbyid")]
    public async Task<IActionResult> GetById([FromQuery] GetSocialMediaRequest getSocialMediaRequest)
    {
        var result = await _socialMediaService.GetAsync(getSocialMediaRequest);
        return Ok(result);
    }

    [HttpPost("add")]
    public async Task<IActionResult> Add([FromBody] CreateSocialMediaRequest createSocialMediaRequest)
    {
        var result = await _socialMediaService.AddAsync(createSocialMediaRequest);
        return Ok(result);
    }

    [HttpPut("update")]
    public async Task<IActionResult> Update([FromQuery] int id, [FromBody] UpdateSocialMediaRequest updateSocialMediaRequest)
    {
        var result = await _socialMediaService.UpdateAsync(id, updateSocialMediaRequest);
        return Ok(result);
    }

    [HttpDelete("delete")]
    public async Task<IActionResult> Delete([FromQuery] DeleteSocialMediaRequest deleteSocialMediaRequest)
    {
        var result = await _socialMediaService.DeleteAsync(deleteSocialMediaRequest);
        return Ok(result);
    }

}

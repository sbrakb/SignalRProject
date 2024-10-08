using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstracts;
using SignalR.BusinessLayer.Dtos.Requests.Feature;

namespace SignaIRApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FeaturesController : ControllerBase
{
    private readonly IFeatureService _featureService;

    public FeaturesController(IFeatureService featureService)
    {
        _featureService = featureService;
    }

    [HttpGet("getall")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _featureService.GetListAsync();
        return Ok(result);
    }

    [HttpGet("getbyid")]
    public async Task<IActionResult> GetById([FromQuery] GetFeatureRequest getFeatureRequest)
    {
        var result = await _featureService.GetAsync(getFeatureRequest);
        return Ok(result);
    }

    [HttpPost("add")]
    public async Task<IActionResult> Add([FromBody] CreateFeatureRequest createFeatureRequest)
    {
        var result = await _featureService.AddAsync(createFeatureRequest);
        return Ok(result);
    }

    [HttpPut("update")]
    public async Task<IActionResult> Update([FromQuery] int id, [FromBody] UpdateFeatureRequest updateFeatureRequest)
    {
        var result = await _featureService.UpdateAsync(id, updateFeatureRequest);
        return Ok(result);
    }

    [HttpDelete("delete")]
    public async Task<IActionResult> Delete([FromQuery] DeleteFeatureRequest deleteFeatureRequest)
    {
        var result = await _featureService.DeleteAsync(deleteFeatureRequest);
        return Ok(result);
    }

}

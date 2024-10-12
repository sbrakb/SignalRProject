using Microsoft.AspNetCore.Mvc;
using SignalRWebUI.BusinessLayer.Abstracts;
using SignalRWebUI.BusinessLayer.Dtos.Requests.Discount;

namespace SignaIRApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DiscountsController : ControllerBase
{
    private readonly IDiscountService _discountService;

    public DiscountsController(IDiscountService discountService)
    {
        _discountService = discountService;
    }

    [HttpGet("getall")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _discountService.GetListAsync();
        return Ok(result);
    }

    [HttpGet("getbyid")]
    public async Task<IActionResult> GetById([FromQuery] GetDiscountRequest getDiscountRequest)
    {
        var result = await _discountService.GetAsync(getDiscountRequest);
        return Ok(result);
    }

    [HttpPost("add")]
    public async Task<IActionResult> Add([FromBody] CreateDiscountRequest createDiscountRequest)
    {
        var result = await _discountService.AddAsync(createDiscountRequest);
        return Ok(result);
    }

    [HttpPut("update")]
    public async Task<IActionResult> Update([FromQuery] int id, [FromBody] UpdateDiscountRequest updateDiscountRequest)
    {
        var result = await _discountService.UpdateAsync(id, updateDiscountRequest);
        return Ok(result);
    }

    [HttpDelete("delete")]
    public async Task<IActionResult> Delete([FromQuery] DeleteDiscountRequest deleteDiscountRequest)
    {
        var result = await _discountService.DeleteAsync(deleteDiscountRequest);
        return Ok(result);
    }

}

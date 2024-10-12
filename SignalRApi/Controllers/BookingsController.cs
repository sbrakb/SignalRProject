using Microsoft.AspNetCore.Mvc;
using SignalRWebUI.BusinessLayer.Abstracts;
using SignalRWebUI.BusinessLayer.Dtos.Requests.Booking;

namespace SignaIRApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookingsController : ControllerBase
{
    private readonly IBookingService _bookingService;

    public BookingsController(IBookingService bookingService)
    {
        _bookingService = bookingService;
    }

    [HttpGet("getall")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _bookingService.GetListAsync();
        return Ok(result);
    }

    [HttpGet("getbyid")]
    public async Task<IActionResult> GetById([FromQuery]GetBookingRequest getBookingRequest)
    {
        var result = await _bookingService.GetAsync(getBookingRequest);
        return Ok(result);
    }

    [HttpPost("add")]
    public async Task<IActionResult> Add([FromBody ]CreateBookingRequest createBookingRequest)
    {
        var result = await _bookingService.AddAsync(createBookingRequest);
        return Ok(result);
    }

    [HttpPut("update")]
    public async Task<IActionResult> Update([FromQuery] int id, [FromBody]UpdateBookingRequest updateBookingRequest)
    {
        var result = await _bookingService.UpdateAsync(id, updateBookingRequest);
        return Ok(result);
    }

    [HttpDelete("delete")]
    public async Task<IActionResult> Delete([FromQuery] DeleteBookingRequest deleteBookingRequest)
    {
        var result = await _bookingService.DeleteAsync(deleteBookingRequest);
        return Ok(result);
    }


}
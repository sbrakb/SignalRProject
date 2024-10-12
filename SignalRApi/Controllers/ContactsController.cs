using Microsoft.AspNetCore.Mvc;
using SignalRWebUI.BusinessLayer.Abstracts;
using SignalRWebUI.BusinessLayer.Dtos.Requests.Contact;

namespace SignaIRApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ContactsController : ControllerBase
{
    private readonly IContactService _contactService;

    public ContactsController(IContactService contactService)
    {
        _contactService = contactService;
    }

    [HttpGet("getall")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _contactService.GetListAsync();
        return Ok(result);
    }

    [HttpGet("getbyid")]
    public async Task<IActionResult> GetById([FromQuery] GetContactRequest getContactRequest)
    {
        var result = await _contactService.GetAsync(getContactRequest);
        return Ok(result);
    }

    [HttpPost("add")]
    public async Task<IActionResult> Add([FromBody] CreateContactRequest createContactRequest)
    {
        var result = await _contactService.AddAsync(createContactRequest);
        return Ok(result);
    }

    [HttpPut("update")]
    public async Task<IActionResult> Update([FromQuery] int id, [FromBody] UpdateContactRequest updateContactRequest)
    {
        var result = await _contactService.UpdateAsync(id, updateContactRequest);
        return Ok(result);
    }

    [HttpDelete("delete")]
    public async Task<IActionResult> Delete([FromQuery] DeleteContactRequest deleteContactRequest)
    {
        var result = await _contactService.DeleteAsync(deleteContactRequest);
        return Ok(result);
    }

}
using Microsoft.AspNetCore.Mvc;
using SignalRWebUI.BusinessLayer.Abstracts;
using SignalRWebUI.BusinessLayer.Dtos.Requests.Category;

namespace SignaIRApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoriesController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet("getall")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _categoryService.GetListAsync();
        return Ok(result);
    }

    [HttpGet("getbyid/{id}")]
    public async Task<IActionResult> GetById([FromRoute]int id)
    {
        GetCategoryRequest getCategoryRequest = new GetCategoryRequest { Id = id };
        var result = await _categoryService.GetAsync(getCategoryRequest);
        return Ok(result);
    }

    [HttpPost("add")]
    public async Task<IActionResult> Add([FromBody] CreateCategoryRequest createCategoryRequest)
    {
        var result = await _categoryService.AddAsync(createCategoryRequest);
        return Ok(result);
    }

    [HttpPut("update/{id}")]
    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateCategoryRequest updateCategoryRequest)
    {
        var result = await _categoryService.UpdateAsync(id, updateCategoryRequest);
        return Ok(result);
    }

    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        DeleteCategoryRequest deleteCategoryRequest = new DeleteCategoryRequest { Id = id };
        var result = await _categoryService.DeleteAsync(deleteCategoryRequest);
        return Ok(result);
    }

}

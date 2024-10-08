using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstracts;
using SignalR.BusinessLayer.Dtos.Requests.Product;

namespace SignaIRApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet("getall")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _productService.GetListAsync();
        return Ok(result);
    }

    [HttpGet("getbyid")]
    public async Task<IActionResult> GetById([FromQuery] GetProductRequest getProductRequest)
    {
        var result = await _productService.GetAsync(getProductRequest);
        return Ok(result);
    }

	[HttpGet("getproductswithcategory")]
	public async Task<IActionResult> GetProductsWithCategory()
	{
		var result = await _productService.GetProductsWithCategories();
		return Ok(result);
	}


	[HttpGet("getwithcategories")]
    public IActionResult GetWithCategories()
    {
        var result =  _productService.GetProductsWithCategories();
        return Ok(result);
    }

    [HttpPost("add")]
    public async Task<IActionResult> Add([FromBody] CreateProductRequest createProductRequest)
    {
        var result = await _productService.AddAsync(createProductRequest);
        return Ok(result);
    }

    [HttpPut("update")]
    public async Task<IActionResult> Update([FromQuery] int id, [FromBody] UpdateProductRequest updateProductRequest)
    {
        var result = await _productService.UpdateAsync(id, updateProductRequest);
        return Ok(result);
    }

    [HttpDelete("delete")]
    public async Task<IActionResult> Delete([FromQuery] DeleteProductRequest deleteProductRequest)
    {
        var result = await _productService.DeleteAsync(deleteProductRequest);
        return Ok(result);
    }

}

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.Requests.Category;
using SignalRWebUI.Dtos.Responses.Category;
using System.Text;

namespace SignalRWebUI.Controllers;

public class CategoryController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public CategoryController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IActionResult> Index()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("http://localhost:5118/api/Categories/getall");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<GetCategoryResponse>>(jsonData);
            return View(result);
        }
        return View();
    }

    [HttpGet]
    public IActionResult CreateCategory()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateCategory(CreateCategoryRequest createCategoryRequest)
    {
        createCategoryRequest.Status = true;
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(createCategoryRequest);
        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var responseMessage = await client.PostAsync("http://localhost:5118/api/Categories/add", stringContent);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        else
        {
            var error = await responseMessage.Content.ReadAsStringAsync();
            ModelState.AddModelError(string.Empty, $"API Error: {error}");
            return View();
        }
    }


    public async Task<IActionResult> DeleteCategory(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var response = await client.DeleteAsync($"http://localhost:5118/api/Categories/delete/{id}");
        if (response.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        else
        {
            var error = await response.Content.ReadAsStringAsync();
            ModelState.AddModelError(string.Empty, $"API Error: {error}");
            return View();
        }
    }


    public async Task<IActionResult> UpdateCategory(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var response = await client.GetAsync($"http://localhost:5118/api/Categories/getbyid/{id}");
        if (response.IsSuccessStatusCode)
        {
            var jsonData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<UpdateCategoryRequest>(jsonData);
            return View(result);
        }
        return View();
    }

    [HttpPut]
    public async Task<IActionResult> UpdateCategory(UpdateCategoryRequest updateCategoryRequest)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(updateCategoryRequest);
        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var responseMessage = await client.PutAsync($"http://localhost:5118/api/Categories/update/{updateCategoryRequest.Id}", stringContent);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        else
        {
            var error = await responseMessage.Content.ReadAsStringAsync();
            ModelState.AddModelError(string.Empty, $"API Error: {error}");
            return View();
        }
    }

}

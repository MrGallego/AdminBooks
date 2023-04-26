using AdminBooks.Data.Models.Response;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AdminBooks.App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {


        [HttpGet("{isbn}")]
        public async Task<IActionResult> GetBook(string isbn)
        {
            try
            {
                string url = $"https://www.googleapis.com/books/v1/volumes?q={isbn}";
                HttpClient httpClient = new();
                HttpResponseMessage response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    BooksResponse? book = JsonConvert.DeserializeObject<BooksResponse>(json);

                    return Ok(book);
                }
                else
                {
                    string errorResponse = await response.Content.ReadAsStringAsync();
                    string errorMessage = JToken.Parse(errorResponse)["error"].ToString();

                    return StatusCode((int)response.StatusCode, errorMessage);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }



        }
    }
}

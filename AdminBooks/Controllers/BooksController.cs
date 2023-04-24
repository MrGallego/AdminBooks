using AdminBooks.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AdminBooks.Controllers
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
                var query = "AIzaSyBHDqBQ9uNJv3qdTh9ZhL3Lq9lirhwvasE";
                var url = $"https://www.googleapis.com/books/v1/volumes?q={isbn}";
                var httpClient = new HttpClient();
                var response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var book = JsonConvert.DeserializeObject<Books>(json);

                    return Ok(book);
                }
                else
                {
                    var errorResponse = await response.Content.ReadAsStringAsync();
                    var errorMessage = JToken.Parse(errorResponse)["error"].ToString();

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

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
            var url = $"http://openlibrary.org/api/books?bibkeys=ISBN:{isbn}&format=json&jscmd=details";
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
                return StatusCode((int)response.StatusCode, "Ocurrió un error al realizar la peticion.");
            }
        }
    }
}

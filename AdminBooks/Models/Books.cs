using Newtonsoft.Json;

namespace AdminBooks.Models
{
    public class Books
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("authors")]
        public Author[] Authors { get; set; }

        [JsonProperty("publishers")]
        public Publisher[] Publishers { get; set; }
    }

    public class Author
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Publisher
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}


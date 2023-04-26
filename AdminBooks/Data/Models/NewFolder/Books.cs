namespace AdminBooks.Data.Models.NewFolder
{
    public class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public int Isbn { get; set; }
        public int PagesCount { get; set; }
        public string Language { get; set; }
        public string ImageLink { get; set; }
        public string MyProperty { get; set; }
        public DateTime Created { get; set; }
        = DateTime.Now;


        
    }
}

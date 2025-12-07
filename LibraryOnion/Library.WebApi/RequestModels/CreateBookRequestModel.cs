namespace Library.WebApi.RequestModels
{
    public class CreateBookRequestModel
    {
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
    }
}


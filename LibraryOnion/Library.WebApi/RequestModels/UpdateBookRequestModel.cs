namespace Library.WebApi.RequestModels
{
    public class UpdateBookRequestModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
    }
}


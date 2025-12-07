namespace Library.WebApi.ResponseModels
{
    public class BookTagResponseModel
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int TagId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}


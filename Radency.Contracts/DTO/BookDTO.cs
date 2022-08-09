namespace Radency.Contracts.DTO
{
    public class BookDTO
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Cover { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public string Genve { get; set; }

        public decimal Rating { get; set; }

        public ICollection<ReviewDTO> Reviews { get; set; }
    }

    public class ReviewDTO
    {
        public int Id { get; set; }

        public string Message { get; set; }

        public string Reviewer { get; set; }
    }
}

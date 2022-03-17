namespace modelValidation.Models.Mymodel
{
    public class Book
    {
        public int Bookid { get; set; }

        public string BookName { get; set; }

        public string Author { get; set; }

        public int price { get; set; }

        public string Description { get; set; }

        public List<string> BookType { get; set; }
    }
}

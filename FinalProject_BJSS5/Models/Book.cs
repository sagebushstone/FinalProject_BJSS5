namespace FinalProject_BJSS5.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int PublishYear { get; set; }

        public string GetBooks()
        {
            return $"{Id}  {Name}  {Title}  {Author}  {Publisher}  {PublishYear}";
        }
    }
}

namespace FinalProject_BJSS5.Models
{
    public class Favorite
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Food { get; set; }
        public string Color { get; set; }
        public string Movie { get; set; }
        public string Drink { get; set; }

        public string GetFavorite()
        {
            return $"{Id}  {Name}  {Food}  {Color}  {Movie}  {Drink}";
        }
    }
}
    


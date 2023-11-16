using System.Drawing;

namespace FinalProject_BJSS5.Models
{
    public class Hobbies
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Hobby1 { get; set; }
        public string Hobby2 { get; set; }
        public string Hobby3 { get; set; }
        public string Hobby4 { get; set; }

        public string GetHobby()
        {
            return $"{Id}  {Name}  {Hobby1}  {Hobby2}  {Hobby3}  {Hobby4}";
        }
    }
}

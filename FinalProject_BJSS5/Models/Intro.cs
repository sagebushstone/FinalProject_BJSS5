using System.Xml.Linq;

namespace FinalProject_BJSS5.Models
{
    public class Intro
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateOnly BirthDate { get; set; }
        public string? CollegeProgram { get; set; }
        public int CollegeYear { get; set; }
        public string GetIntro()
        {
            return $"{Id}  {FirstName}  {LastName}  {BirthDate}  {CollegeProgram}  {CollegeYear}";
        }
    }
}

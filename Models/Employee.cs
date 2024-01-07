using System.ComponentModel.DataAnnotations;

namespace Scores.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int PositivePoints { get; set; }
        public int NegativePoints { get; set; }
    }
}

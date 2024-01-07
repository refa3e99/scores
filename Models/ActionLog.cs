using System.ComponentModel.DataAnnotations;

namespace Scores.Models
{
    public class ActionLog
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string? Action { get; set; }
        public int PointsAdded { get; set; }

    }
}

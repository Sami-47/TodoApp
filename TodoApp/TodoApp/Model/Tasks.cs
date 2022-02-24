using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace TodoApp.Model
{
    public class Tasks
    {
        [Key]
        public int UserId { get; set; }
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = String.Empty;
        public enum Status { PENDING, COMPLETED }

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }

        public string? UserName { get; set; } 

    }
}

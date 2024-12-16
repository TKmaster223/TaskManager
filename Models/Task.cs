using System.ComponentModel.DataAnnotations;

namespace TaskManagerApi.Models
{
    public class Tasks
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string DueDate { get; set; } = string.Empty;
        public TaskStatus Status { get; set; }
    }

    public enum TaskStatus
    {
        NotStarted,
        InProgress,
        Completed
    }
}
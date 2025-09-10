namespace TaskFlow.Models.Entities
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public int Priority { get; set; } = 2; // 1=Low, 2=Medium, 3=High, 4=Critical
        public int Status { get; set; } = 1; // 1=Todo, 2=InProgress, 3=Completed
        public DateTime? DueDate { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string UserId { get; set; } = "";
        public int CategoryId { get; set; } = 1;
    }
}
namespace TaskFlow.Models.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Color { get; set; } = "#007bff";
        public string UserId { get; set; } = "";
    }
}
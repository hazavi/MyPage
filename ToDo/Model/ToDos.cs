namespace ToDo.Model
{
    public class ToDos
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateOnly DueDate { get; set; }
        public DateTime DateCreated { get; set; }
        public bool isDone { get; set; }
        public string? Color { get; set; } = "#ffd700";



    }
}

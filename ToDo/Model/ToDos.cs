namespace ToDo.Model
{
    public class ToDos
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<string> Text { get; set; }
        public DateOnly DueDate { get; set; }
        public DateTime DateCreated { get; set; }




    }
}

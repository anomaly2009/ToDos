namespace ToDos.Models
{
    public class Tasks
    {
        public int Id { get; set; }
        public required string TaskName { get; set; }
        public string TaskDescription { get; set; }
    }
}

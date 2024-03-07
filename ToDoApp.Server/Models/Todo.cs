namespace ToDoApp.Server.Models
{
    public class Todo
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public bool IsCompleted { get; set; }
        public DateTimeOffset CompletedDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTimeOffset DeletedDate { get; set; }
    }
}

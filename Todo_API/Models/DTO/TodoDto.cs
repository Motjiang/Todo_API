namespace Todo_API.Models.DTO
{
    public class TodoDto
    {
        public string TaskDescription { get; set; }
        public DateTime TaskCreatedDate { get; set; }
        public bool IsTaskCompleted { get; set; }
        public DateTime? TaskCompletedDate { get; set; }
    }
}

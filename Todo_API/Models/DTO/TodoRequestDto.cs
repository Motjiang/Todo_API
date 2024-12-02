namespace Todo_API.Models.DTO
{
    public class TodoRequestDto
    {
        public Guid TaskId { get; set; }
        public string TaskDescription { get; set; }
        public DateTime TaskCreatedDate { get; set; }
        public bool IsTaskCompleted { get; set; }
        public DateTime? TaskCompletedDate { get; set; }
        public bool IsTaskDeleted { get; set; }
        public DateTime? TaskDeletedDate { get; set; }
    }
}

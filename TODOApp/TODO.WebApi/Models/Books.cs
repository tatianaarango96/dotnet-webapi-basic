namespace TODO.WebApi.Models
{
    public class Books
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public bool Iscompleted { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}

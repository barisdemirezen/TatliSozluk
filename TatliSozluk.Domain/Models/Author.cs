namespace TatliSozluk.Domain.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreateDate { get; set; }
        public virtual List<Post>? Posts { get; set; }
    }
}

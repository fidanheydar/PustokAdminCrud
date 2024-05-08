namespace PustokMvc.Models
{
    public class Tag:BaseEntity
    {
        public string Name { get; set; }
        public List<BookTag>? Tags { get; set; }
    }
}

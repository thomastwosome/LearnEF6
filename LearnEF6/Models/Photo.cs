namespace LearnEF6.Models
{
    public class Photo : BaseEntity
    {
        public byte[] Image { get; set; }

        public string Caption { get; set; }
    }
}
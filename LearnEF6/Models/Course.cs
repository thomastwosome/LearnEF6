namespace LearnEF6.Models
{
    public class Course : BaseEntity
    {
        public string Name { get; set; }

        public int Units { get; set; }
    }
}
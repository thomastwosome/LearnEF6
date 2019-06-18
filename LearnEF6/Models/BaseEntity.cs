using System;

namespace LearnEF6.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Modified { get; set; }
    }
}
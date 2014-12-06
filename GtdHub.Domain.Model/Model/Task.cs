using System;

namespace GtdHub.Domain.Model
{
    public class Task : BaseEntity
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
    }
}
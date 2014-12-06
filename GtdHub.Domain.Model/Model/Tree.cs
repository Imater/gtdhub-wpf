using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GtdHub.Domain.Model
{
    public class Tree : BaseEntity
    {
        public String Title { get; set; }
        public ObservableCollection<Note> Notes { get; set; }
        public ObservableCollection<Task> Tasks { get; set; }
        public ObservableCollection<Tree> Items { get; set; }
        public Guid ParentId { get; set; }
    }
}
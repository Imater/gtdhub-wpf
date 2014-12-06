using System;
using System.Collections.ObjectModel;
using GtdHub.Domain.Model;

namespace GtdHubApp.ViewModel
{
    public class ViewModelMain : ViewModelBase
    {
        public ObservableCollection<Note> Notes { get; set; }
        public ObservableCollection<Tree> Trees { get; set; }
        public ViewModelMain()
        {
            Notes = new ObservableCollection<Note>
            {
                new Note{Title = "Notebook for Home", Id = Guid.NewGuid()},
                new Note{Title = "Notebook for Work", Id = Guid.NewGuid()}
            };

            var tree1 = new Tree
            {
                Title = "Tree for Work",
                Id = Guid.NewGuid(),
                Items = new ObservableCollection<Tree>
                {
                    new Tree {Title = "child 1"},
                    new Tree {Title = "child 2", Items = new ObservableCollection<Tree>
                    {
                        new Tree{ Title = "Subchild"}
                    }},
                    new Tree {Title = "child 3"},
                    new Tree {Title = "child 4"},
                    new Tree {Title = "child 5"},
                    new Tree {Title = "child 6"},
                    new Tree {Title = "child 7"}
                }
            };
            Trees = new ObservableCollection<Tree>
            {
                new Tree{Title = "Tree for Home", Id = Guid.NewGuid()},
                tree1
            };
        }

    }
}

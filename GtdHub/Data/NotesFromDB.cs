using System.Collections.ObjectModel;
using GtdHub.Domain.Model;

namespace GtdHubApp.Data
{
    public class NotesFromDb
    {
        public static ObservableCollection<Note> GetNotesFromDatabase()
        {
            return new ObservableCollection<Note>
            {
                new Note {Title = "2010 год"},
                new Note {Title = "2011 год"},
                new Note {Title = "2012 год"},
                new Note {Title = "2013 год"},
                new Note {Title = "2014 год"},
                new Note {Title = "2015 год"}
            };}
    }
}

using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstWebsite.Pages
{
    public partial class NotesApp : ComponentBase
    {
        // Note model
        public class Note
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Content { get; set; }
            public string Tag { get; set; }
        }

        private int currentNoteId = 1; // For assigning IDs to notes
        private string newNoteTitle = string.Empty;
        private string newNoteContent = string.Empty;
        private string newNoteTag = string.Empty;
        private string searchQuery = string.Empty;

        private List<Note> notes = new();
        private List<Note> filteredNotes => notes
            .Where(n => string.IsNullOrEmpty(searchQuery) || n.Title.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) || n.Content.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) || n.Tag.Contains(searchQuery, StringComparison.OrdinalIgnoreCase))
            .ToList();

        // Add a new note
        private void AddNote()
        {
            if (!string.IsNullOrEmpty(newNoteTitle) && !string.IsNullOrEmpty(newNoteContent))
            {
                notes.Add(new Note
                {
                    Id = currentNoteId++,
                    Title = newNoteTitle,
                    Content = newNoteContent,
                    Tag = newNoteTag
                });

                newNoteTitle = string.Empty;
                newNoteContent = string.Empty;
                newNoteTag = string.Empty;
            }
        }

        // Edit an existing note
        private void EditNote(int noteId)
        {
            var note = notes.FirstOrDefault(n => n.Id == noteId);
            if (note != null)
            {
                newNoteTitle = note.Title;
                newNoteContent = note.Content;
                newNoteTag = note.Tag;

                notes.Remove(note);
            }
        }

        // Delete a note
        private void DeleteNote(int noteId)
        {
            var note = notes.FirstOrDefault(n => n.Id == noteId);
            if (note != null)
            {
                notes.Remove(note);
            }
        }
    }
}

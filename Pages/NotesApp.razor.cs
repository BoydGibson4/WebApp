using Microsoft.AspNetCore.Components;  // Importing the necessary namespace for Blazor components
using System;  // Importing the System namespace for basic functionality
using System.Collections.Generic;  // Importing the Collections.Generic namespace for using lists
using System.Linq;  // Importing the Linq namespace for querying collections

namespace FirstWebsite.Pages  // Defining the namespace for the NotesApp page
{
    public partial class NotesApp : ComponentBase  // Partial class for the NotesApp component
    {
        // Note model definition
        public class Note  // Represents a single note
        {
            public int Id { get; set; }  // Unique identifier for the note
            public string Title { get; set; }  // Title of the note
            public string Content { get; set; }  // Content of the note
            public string Tag { get; set; }  // Tag for categorizing the note
        }

        private int currentNoteId = 1;  // Variable for assigning IDs to notes, starts at 1
        private string newNoteTitle = string.Empty;  // Title for a new note
        private string newNoteContent = string.Empty;  // Content for a new note
        private string newNoteTag = string.Empty;  // Tag for a new note
        private string searchQuery = string.Empty;  // Search query for filtering notes

        private List<Note> notes = new();  // List to hold all notes
        // Computed property to filter notes based on the search query
        private List<Note> filteredNotes => notes
            .Where(n => string.IsNullOrEmpty(searchQuery) || 
                        n.Title.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) || 
                        n.Content.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) || 
                        n.Tag.Contains(searchQuery, StringComparison.OrdinalIgnoreCase))
            .ToList();  // Returns the filtered list of notes

        // Method to add a new note
        private void AddNote()
        {
            // Check if both title and content are provided
            if (!string.IsNullOrEmpty(newNoteTitle) && !string.IsNullOrEmpty(newNoteContent))
            {
                // Create a new note and add it to the notes list
                notes.Add(new Note
                {
                    Id = currentNoteId++,  // Assign current ID and then increment it
                    Title = newNoteTitle,  // Set the title
                    Content = newNoteContent,  // Set the content
                    Tag = newNoteTag  // Set the tag
                });

                // Clear the input fields after adding the note
                newNoteTitle = string.Empty;
                newNoteContent = string.Empty;
                newNoteTag = string.Empty;
            }
        }

        // Method to edit an existing note
        private void EditNote(int noteId)
        {
            // Find the note by ID
            var note = notes.FirstOrDefault(n => n.Id == noteId);
            if (note != null)  // If the note exists
            {
                // Populate the input fields with the note's data
                newNoteTitle = note.Title;
                newNoteContent = note.Content;
                newNoteTag = note.Tag;

                // Remove the note from the list to prepare for updating it
                notes.Remove(note);
            }
        }

        // Method to delete a note
        private void DeleteNote(int noteId)
        {
            // Find the note by ID
            var note = notes.FirstOrDefault(n => n.Id == noteId);
            if (note != null)  // If the note exists
            {
                // Remove the note from the list
                notes.Remove(note);
            }
        }
    }
}

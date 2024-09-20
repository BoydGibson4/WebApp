using Microsoft.AspNetCore.Components;  // Importing the necessary namespace for Blazor components

namespace FirstWebsite.Pages  // Defining the namespace for the contact page
{
    public partial class ContactPage  // Partial class for the ContactPage component
    {
        // Properties to hold user input data
        private string name { get; set; } = string.Empty;  // Property to store the user's name, initialized to an empty string
        private string email { get; set; } = string.Empty;  // Property to store the user's email, initialized to an empty string
        private string message { get; set; } = string.Empty;  // Property to store the user's message, initialized to an empty string
        private string formFeedback = "";  // Property to store feedback message after form submission, initialized to an empty string

        // Method to handle form submission logic
        private void SubmitForm()  
        {
            // Check if all fields are filled
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(message))
            {
                // If all fields are filled, create a success message
                formFeedback = $"Thank you for reaching out, {name}! We will get back to you shortly.";
            }
            else
            {
                // If any field is empty, prompt the user to fill all fields
                formFeedback = "Please fill out all fields.";
            }
        }
    }
}

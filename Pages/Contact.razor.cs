using Microsoft.AspNetCore.Components;

namespace FirstWebsite.Pages
{
    public partial class ContactPage
    {
        private string name { get; set; } = string.Empty;
        private string email { get; set; } = string.Empty;
        private string message { get; set; } = string.Empty;
        private string formFeedback = "";

        private void SubmitForm()
        {
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(message))
            {
                formFeedback = $"Thank you for reaching out, {name}! We will get back to you shortly.";
            }
            else
            {
                formFeedback = "Please fill out all fields.";
            }
        }
    }
}

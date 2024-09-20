using Microsoft.AspNetCore.Components;

namespace FirstWebsite.Pages
{
    public partial class DateTimePage : ComponentBase // Ensure it inherits from ComponentBase
    {
        private string currentTime; // This variable holds the current time

        protected override void OnInitialized()
        {
            currentTime = System.DateTime.Now.ToString("HH:mm:ss"); // Using System.DateTime
        }

        private void UpdateTime()
        {
            currentTime = System.DateTime.Now.ToString("HH:mm:ss"); // Using System.DateTime
        }
    }
}

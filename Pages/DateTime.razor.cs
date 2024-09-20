using Microsoft.AspNetCore.Components;  // Importing the necessary namespace for Blazor components

namespace FirstWebsite.Pages  // Defining the namespace for the DateTime page
{
    public partial class DateTimePage : ComponentBase  // Partial class for the DateTime component, inheriting from ComponentBase
    {
        private string currentTime;  // Variable to hold the current time as a string

        // This method is called when the component is initialized
        protected override void OnInitialized()  
        {
            // Set the currentTime variable to the current time formatted as "HH:mm:ss"
            currentTime = System.DateTime.Now.ToString("HH:mm:ss"); 
        }

        // Method to update the current time
        private void UpdateTime()  
        {
            // Update the currentTime variable to the new current time
            currentTime = System.DateTime.Now.ToString("HH:mm:ss"); 
        }
    }
}

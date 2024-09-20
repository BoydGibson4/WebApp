using Microsoft.AspNetCore.Components;  // Importing the necessary namespace for Blazor components

namespace FirstWebsite.Pages  // Defining the namespace for the Counter page
{
    public partial class Counter  // Partial class for the Counter component
    {
        private int currentCount = 0;  // Field to store the current count, initialized to zero

        // Method to increment the current count
        private void IncrementCount()  
        {
            currentCount++;  // Increases the value of currentCount by one each time this method is called
        }
    }
}

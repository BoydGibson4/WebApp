using Microsoft.AspNetCore.Components;  // Importing the necessary namespace for Blazor components
using Microsoft.JSInterop;  // Importing the namespace for JavaScript interop

public partial class Home  // Partial class for the Home component
{
    [Inject] private IJSRuntime JS { get; set; }  // Injecting IJSRuntime to allow JavaScript interop

    // Method to smoothly scroll to a specified section of the page
    private async Task ScrollToSection(string sectionId)
    {
        // Calling a JavaScript function to perform the smooth scroll
        await JS.InvokeVoidAsync("smoothScrollToElement", sectionId);
    }
}

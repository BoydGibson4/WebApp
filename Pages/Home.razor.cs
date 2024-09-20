using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

public partial class Home
{
    [Inject] private IJSRuntime JS { get; set; }

    private async Task ScrollToSection(string sectionId)
    {
        await JS.InvokeVoidAsync("smoothScrollToElement", sectionId);
    }
}

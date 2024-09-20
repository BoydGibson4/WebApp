using Microsoft.AspNetCore.Components;  // Importing the necessary namespace for Blazor components
using System;  // Importing the System namespace for basic functionality

namespace FirstWebsite.Pages  // Defining the namespace for the Quote page
{
    public partial class Quote  // Partial class for the Quote component
    {
        // Array of quotes to choose from
        private string[] quotes = new[]  
        {
            "The journey of a thousand miles begins with one step.",
            "Life is what happens when you're busy making other plans.",
            "Success is not final, failure is not fatal: It is the courage to continue that counts.",
            "Do not watch the clock. Do what it does. Keep going."
        };

        private string randomQuote;  // Variable to hold the randomly selected quote

        // This method is called when the component is initialized
        protected override void OnInitialized()  
        {
            GenerateRandomQuote();  // Generate a random quote when the component initializes
        }

        // Method to generate a random quote
        public void GenerateRandomQuote()  
        {
            var random = new Random();  // Create a new instance of the Random class
            // Select a random quote from the array
            randomQuote = quotes[random.Next(quotes.Length)];  
        }
    }
}

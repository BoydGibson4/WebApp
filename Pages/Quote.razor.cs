using Microsoft.AspNetCore.Components;
using System;

namespace FirstWebsite.Pages
{
    public partial class Quote
    {
        private string[] quotes = new[]
        {
            "The journey of a thousand miles begins with one step.",
            "Life is what happens when you're busy making other plans.",
            "Success is not final, failure is not fatal: It is the courage to continue that counts.",
            "Do not watch the clock. Do what it does. Keep going."
        };

        private string randomQuote;

        protected override void OnInitialized()
        {
            GenerateRandomQuote();
        }

        public void GenerateRandomQuote() // Ensure this is public
        {
            var random = new Random();
            randomQuote = quotes[random.Next(quotes.Length)];
        }
    }
}

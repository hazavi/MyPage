using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BookLibrary.Service
{

    public class OpenLibraryService
    {
        private readonly HttpClient _httpClient;

        public OpenLibraryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<OpenLibraryBookResponse> SearchBooksAsync(string query)
        {
            var apiUrl = $"http://openlibrary.org/search.json?q={query}";
            Console.WriteLine("API URL: " + apiUrl);

            var response = await _httpClient.GetAsync(apiUrl);

            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            Console.WriteLine("API Response: " + json);

            return JsonSerializer.Deserialize<OpenLibraryBookResponse>(json);
        }

    }

    public class OpenLibraryBookResponse
    {
        [JsonPropertyName("docs")]
        public List<Book> Books { get; set; }
    }

    public class Book
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("author_name")]
        public List<string> Authors { get; set; }

        // Add other properties as needed
    }

}

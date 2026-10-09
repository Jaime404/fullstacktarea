using System.Net.Http.Json;
using YourApp.Models;

namespace YourApp.Services
{
    public class StudentService
    {
        private readonly HttpClient _http;

        public StudentService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Student>> GetStudentsAsync()
        {
            return await _http.GetFromJsonAsync<List<Student>>(
                "https://jsonplaceholder.typicode.com/users"
            );
        }
    }
}
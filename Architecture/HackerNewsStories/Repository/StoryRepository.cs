using BestHackerNewsStoriesFront.Architecture.HackerNewsStories.DTOs;
using BestHackerNewsStoriesFront.Architecture.HackerNewsStories.Interfaces;
using System.Net.Http.Json;

namespace BestHackerNewsStoriesFront.Architecture.HackerNewsStories.Repository
{
    public class StoryRepository : IStoryRepository
    {
        private readonly HttpClient _httpClient;

        public StoryRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<StoryDto>> GetBestStoriesAsync(int count)
        {
            string url = $"https://apihacker-ebf6bydabxhjgvf0.canadacentral-01.azurewebsites.net/stories/best-stories?n={count}";
            var stories = await _httpClient.GetFromJsonAsync<List<StoryDto>>(url);
            return stories ?? new List<StoryDto>();
        }
    }
}

using BestHackerNewsStoriesFront.Architecture.HackerNewsStories.DTOs;
using BestHackerNewsStoriesFront.Architecture.HackerNewsStories.Interfaces;

namespace BestHackerNewsStoriesFront.Architecture.HackerNewsStories.Services
{
    public class StoryService : IStoryService
    {
        private readonly IStoryRepository _repository;

        public StoryService(IStoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<StoryDto>> GetTopStoriesAsync(int count)
        {
            return await _repository.GetBestStoriesAsync(count);
        }
    }
}

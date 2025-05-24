using BestHackerNewsStoriesFront.Architecture.HackerNewsStories.DTOs;

namespace BestHackerNewsStoriesFront.Architecture.HackerNewsStories.Interfaces
{
    public interface IStoryRepository
    {
        Task<List<StoryDto>> GetBestStoriesAsync(int count);
    }
}

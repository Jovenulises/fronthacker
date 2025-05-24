using BestHackerNewsStoriesFront.Architecture.HackerNewsStories.DTOs;

namespace BestHackerNewsStoriesFront.Architecture.HackerNewsStories.Interfaces
{
    public interface IStoryService
    {
        Task<List<StoryDto>> GetTopStoriesAsync(int count);
    }
}

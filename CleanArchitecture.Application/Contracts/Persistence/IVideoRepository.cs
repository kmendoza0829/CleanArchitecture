using CleanArchitecture.Domain;

namespace CleanArchitecture.Application.Contracts.Persistence
{
    public interface IVideoRepository : IAsyncRepository<Video>
    {
        Task<Video> GetVideoByNombreAsync(string nombre);
        Task<IEnumerable<Video>> GetVideoByUsernameAsync(string username);
    }
}

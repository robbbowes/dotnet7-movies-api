using Movies.Application.Models;

namespace Movies.Application.Repositories;

public interface IMovieRepository
{
    Task<bool> CreateAsync(Movie movie, CancellationToken token = default); // could switch out for MovieDTO, with mapper on this Application layer to convert in this DTO when using repository
    Task<Movie?> GetByIdAsync(Guid id, Guid? userId = default, CancellationToken token = default); // as above
    Task<Movie?> GetBySlugAsync(string slug, Guid? userId = default, CancellationToken token = default); // as above
    Task<IEnumerable<Movie>> GetAllAsync(Guid? userId = default, CancellationToken token = default); // as above
    Task<bool> UpdateAsync(Movie movie, CancellationToken token = default); // as above
    Task<bool> DeleteByIdAsync(Guid id, CancellationToken token = default);
    Task<bool> ExistsByIdAsync(Guid id, CancellationToken token = default);
}

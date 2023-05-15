using Movies.Application.Models;

namespace Movies.Application.Repositories;

public interface IMovieRepository
{
    Task<bool> CreateAsync(Movie movie); // could switch out for MovieDTO, with mapper on this Application layer to convert in this DTO when using repository
    Task<Movie?> GetByIdAsync(Guid id); // as above
    Task<Movie?> GetBySlugAsync(string slug); // as above
    Task<IEnumerable<Movie>> GetAllAsync(); // as above
    Task<bool> UpdateAsync(Movie movie); // as above
    Task<bool> DeleteByIdAsync(Guid id);
    Task<bool> ExistsByIdAsync(Guid id);
}

using IT_Project.Data.Base;
using IT_Project.Data.ViewModel;
using System.Threading.Tasks;
using IT_Project.Models;

namespace IT_Project.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);
    }
}

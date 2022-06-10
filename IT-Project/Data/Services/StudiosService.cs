using IT_Project.Data.Base;
using IT_Project.Models;

namespace IT_Project.Data.Services
{
    public class StudiosService:EntityBaseRepository<Studio>, IStudiosService
    {
        public StudiosService(AppDbContext context) : base(context)
        {

        }
    }
}

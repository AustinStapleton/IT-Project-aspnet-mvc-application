using IT_Project.Data.Base;
using IT_Project.Models;
using System.Collections.Generic;

namespace IT_Project.Data.Services
{
    public class ProducersService: EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context) { }

    }
}
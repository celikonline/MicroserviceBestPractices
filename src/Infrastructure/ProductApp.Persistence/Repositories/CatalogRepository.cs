using ProductApp.Application.Interfaces.Repository;
using ProductApp.Persistence.Context;
using ProdutApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Persistence.Repositories
{
    public class CatalogRepository : GenericRepository<Catalog>, ICatalogRepository
    {
        public CatalogRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

    }
}

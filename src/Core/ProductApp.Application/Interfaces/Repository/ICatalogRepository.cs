using ProdutApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Interfaces.Repository
{
    public interface ICatalogRepository : IGenericRepositoryAsync<Catalog>
    {

    }
}

using AutoMapper;
using MediatR;
using ProductApp.Application.Dto;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProductApp.Application.Features.Queries.GetAllCatalogs
{
    public class GetAllCatalogQuery : IRequest<ServiceResponse<List<CatalogViewDto>>>
    {

        public class GetAllCatalogsQueryHandler : IRequestHandler<GetAllCatalogQuery, ServiceResponse<List<CatalogViewDto>>>
        {
            private readonly ICatalogRepository catalogRepository;
            private readonly IMapper mapper;

            public GetAllCatalogsQueryHandler(ICatalogRepository catalogRepository, IMapper mapper)
            {
                this.catalogRepository = catalogRepository;
                this.mapper = mapper;
            }

            public async Task<ServiceResponse<List<CatalogViewDto>>> Handle(GetAllCatalogQuery request, CancellationToken cancellationToken)
            {
                var products = await catalogRepository.GetAllAsync();

                var viewModel = mapper.Map<List<CatalogViewDto>>(products);

                return new ServiceResponse<List<CatalogViewDto>>(viewModel);
            }
        }
    }
}

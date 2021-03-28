using AutoMapper;
using MediatR;
using ProductApp.Application.Dto;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Application.Wrappers;
using ProdutApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProductApp.Application.Features.Command.CreateProduct
{
    public class CreateCatalogCommand : IRequest<ServiceResponse<Guid>>
    {
        public String Name { get; set; }
        public Decimal Value { get; set; }
        public int Quantity { get; set; }

        public class CreateCatalogCommandHandler : IRequestHandler<CreateCatalogCommand, ServiceResponse<Guid>>
        {
            private readonly ICatalogRepository catalogRepository;
            private readonly IMapper mapper;

            public CreateCatalogCommandHandler(ICatalogRepository catalogRepository, IMapper mapper)
            {
                this.catalogRepository = catalogRepository;
                this.mapper = mapper;
            }

            public async Task<ServiceResponse<Guid>> Handle(CreateCatalogCommand request, CancellationToken cancellationToken)
            {
                var catalog = mapper.Map<Catalog>(request);

                await catalogRepository.AddAsync(catalog);

                return new ServiceResponse<Guid>(catalog.Id);
            }
        }
    }
}


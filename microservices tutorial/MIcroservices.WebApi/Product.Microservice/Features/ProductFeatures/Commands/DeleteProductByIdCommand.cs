using MediatR;
using Product.Microservice.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Product.Microservice.Features.ProductFeatures.Commands
{
    public class DeleteProductByIdCommand : IRequest<int>
    {
        public int Id { get; set; }
        

        public class DeleteProductByIdCommandHandler : IRequestHandler<DeleteProductByIdCommand, int>
        {
            private readonly IApplicationContext _context;

            public DeleteProductByIdCommandHandler(IApplicationContext context) 
            {
                _context = context;

            }
            public async Task<int> Handle(CreateProductCommand command, CancellationToken cancellationToken)
            {
                var product = new Product.Microservice.Models.Product { };
                product.Name = command.Name;
                product.Price = command.Price;
                product.Description = command.Description;
                _context.Products.Add(product);
                await _context.SaveChanges();
                return product.Id;
            }

            public async Task<int> Handle(DeleteProductByIdCommand command, CancellationToken cancellationToken)
            {
                var product = _context.Products.Where(a => a.Id == command.Id).FirstOrDefault();
                if (product == null) return default;
                _context.Products.Remove(product);
                await _context.SaveChanges();
                return product.Id;
                
            }
        }
    }
}

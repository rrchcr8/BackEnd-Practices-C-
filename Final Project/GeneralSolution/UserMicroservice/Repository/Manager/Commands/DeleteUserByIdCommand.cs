using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UserMicroservice.Repository.Context;

namespace UserMicroservice.Repository.Manager.Commands
{
    public class DeleteUserByIdCommand : IRequest<int>
    {
        public int Id { get; set; }

        public class DeleteUserByIdCommandHandler : IRequestHandler<DeleteUserByIdCommand, int>
        {
            private readonly IApplicationContext _context;

            public DeleteUserByIdCommandHandler(IApplicationContext context)
            {
                _context = context;

            }       

            public async Task<int> Handle(DeleteUserByIdCommand command, CancellationToken cancellationToken)
            {
                var user = _context.Users.Where(a => a.Id == command.Id).FirstOrDefault();
                if (user == null) return default;
                _context.Users.Remove(user);
                await _context.SaveChanges();
                return user.Id;

            }
        }

    }
}

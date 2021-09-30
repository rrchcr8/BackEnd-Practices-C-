using MediatR;
using System.Threading;
using System.Threading.Tasks;
using UserMicroservice.Models;
using UserMicroservice.Repository.Context;

namespace UserMicroservice.Repository.Manager.Commands
{
    public class CreateUserCommand: IRequest<int>
    {
        public string NickName { get; set; }
        public string RealName { get; set; }
        public string Password { get; set; }

        public class CreateUserCommanddHandler : IRequestHandler<CreateUserCommand, int>
        {
            private readonly IApplicationContext _context;

            public CreateUserCommanddHandler(IApplicationContext context)
            {
                _context = context;

            }
            public async Task<int> Handle(CreateUserCommand command, CancellationToken cancellationToken)
            {
                var user = new User { };
                user.NickName = command.NickName;
                user.RealName = command.RealName;
                user.Password = command.Password;
                
                _context.Users.Add(user);
                await _context.SaveChanges();
                return user.Id;
            }
        }
    }
}

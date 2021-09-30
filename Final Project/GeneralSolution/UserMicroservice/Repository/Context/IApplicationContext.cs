using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using UserMicroservice.Models;

namespace UserMicroservice.Repository.Context
{
    public interface IApplicationContext
        {
            DbSet<User> Users { get; set; }

            Task<int> SaveChanges();
        }
  
}

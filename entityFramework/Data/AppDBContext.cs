using entityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace entityFramework.Data
{

    public class AppDBContext :DbContext
    {
        public AppDBContext()
        {
            
        }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Address> Addresses { get; set; }


    }


}

using System.Data.Entity;

namespace EntityCS.model
{
    public class ClienteContext : DbContext
    {
        public ClienteContext():base("MyContext")
        {
            
        }

        public DbSet<Cliente> Clientes {get; set;}
    }
}
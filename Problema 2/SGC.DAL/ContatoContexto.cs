using System.Data.Entity;
using SGC.Comum.Entities;

namespace SGC.DAL
{
        public class SGCContexto : DbContext
        {
            public DbSet<Contato> Contato { get; set; }

            public SGCContexto()
            {
                Database.CreateIfNotExists();
            }
        }
}

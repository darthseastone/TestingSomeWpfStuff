using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingsomestuff
{
    class OkurLeigaContext : DbContext
    {
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<ApartmentDetails> ApartmentDetails { get; set; }
        public DbSet<ApartmentProblem> ApartmentProblems { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<PostNumber> Postnumbers { get; set; }
    }
}

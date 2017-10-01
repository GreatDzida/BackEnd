using Microsoft.EntityFrameworkCore;
using PartyTime.Core;



namespace PartyTime.Infastructure  
{  
    public class ApplicationContext :DbContext   
    {
        public virtual DbSet<User> Users { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)  
        {  
            
        }  

        protected override void OnModelCreating(ModelBuilder modelBuilder)  
        {  
            base.OnModelCreating(modelBuilder);  
            //new UserMap(modelBuilder.Entity<User>());  
            //new UserProfileMap(modelBuilder.Entity<UserProfile>());  
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFProviders.InMemory;Trusted_Connection=True;");
            }
        }
    }  
}  
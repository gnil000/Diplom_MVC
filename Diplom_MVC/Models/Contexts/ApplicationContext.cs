using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Diplom_MVC.Models.Contexts
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Board>().HasAlternateKey(x=>x.Title);
            builder.Entity<Theme>().HasAlternateKey(x=>x.Titile);
        }

        public DbSet<Board> Boards { get; set; }
        public DbSet<Theme> Theme { get; set; }
        public DbSet<Comment> Comments { get; set; } 
        public DbSet<AnswerOnComment> AnswerOnComments {  get; set; }

    }
}

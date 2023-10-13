using Microsoft.EntityFrameworkCore;

namespace AspNetServer.Data
{
    internal sealed class AppDBContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) =>
            dbContextOptionsBuilder.UseSqlite("Data Source=./Data/AppDB.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var PostToSeed = new Post[6];
            for (int i = 1; i <= PostToSeed.Length; i++)
            {
                PostToSeed[i - 1] = new Post
                {
                    PostId = i,
                    Title = $"Post {i}",
                    Content = $"This is Post {i} and it has very intresting content"
                };
            }

            modelBuilder.Entity<Post>().HasData(PostToSeed);
        }
        
    }
}

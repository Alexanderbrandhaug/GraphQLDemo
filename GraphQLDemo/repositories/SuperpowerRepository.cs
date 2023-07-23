using GraphQLDemo.data;
using GraphQLDemo.interfaces;
using Microsoft.EntityFrameworkCore;

namespace GraphQLDemo.repositories
{
    public class SuperpowerRepository : ISuperpowerRepository
    {
        private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

        public SuperpowerRepository(IDbContextFactory<ApplicationDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        // Now you can create an instance of ApplicationDbContext when needed
        public void SomeRepositoryMethod()
        {
            using var dbContext = _dbContextFactory.CreateDbContext();
            // Perform database operations using the dbContext instance
        }

        // Other repository methods...
    }
}
using GraphQLDemo.models;

namespace GraphQLDemo.data;

    public class Query
    {
        [UseDbContext(typeof(ApplicationDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Superhero> GetSuperheroes([ScopedService] ApplicationDbContext context) =>
            context.Superheroes;
        
        [UseDbContext(typeof(ApplicationDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Superpower> GetSuperPowers([ScopedService] ApplicationDbContext context) =>
            context.Superpowers;
        
        [UseDbContext(typeof(ApplicationDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Movie> GetMovies([ScopedService] ApplicationDbContext context) =>
            context.Movies;
    }

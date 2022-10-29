using SpecificationPatternOnExtensionsSample.Entities;
using SpecificationPatternOnExtensionsSample.Enums;

namespace SpecificationPatternOnExtensionsSample;

public static class DbSeed
{
    public static void Seed(ApplicationDbContext db)
    {
        db.Movies.AddRange(new []
        {
            new Movie() { Name = "Movie 1", Genre = "Triller", MpaaRating = MpaaRating.PG13, Rating = 10.0, ReleaseDate = DateTime.Now },
            new Movie() { Name = "Movie 1", Genre = "Comedy", MpaaRating = MpaaRating.PG13, Rating = 10.0, ReleaseDate = DateTime.Now },
            new Movie() { Name = "Movie 2", Genre = "Triller", MpaaRating = MpaaRating.PG13, Rating = 9.5, ReleaseDate = DateTime.Now.AddYears(-1) },
            new Movie() { Name = "Movie 3", Genre = "Triller", MpaaRating = MpaaRating.PG13, Rating = 8.0, ReleaseDate = DateTime.Now.AddYears(-1) },
            new Movie() { Name = "Movie 4", Genre = "Comedy", MpaaRating = MpaaRating.PG13, Rating = 8.1, ReleaseDate = DateTime.Now.AddYears(-2) },
            new Movie() { Name = "Movie 5", Genre = "Comedy", MpaaRating = MpaaRating.PG13, Rating = 5.0, ReleaseDate = DateTime.Now.AddYears(-2) },
            new Movie() { Name = "Movie 6", Genre = "Comedy", MpaaRating = MpaaRating.PG13, Rating = 2.3, ReleaseDate = DateTime.Now.AddYears(-2) },
            new Movie() { Name = "Movie 7", Genre = "Drama", MpaaRating = MpaaRating.PG13, Rating = 1.5, ReleaseDate = DateTime.Now.AddYears(-10) },
            new Movie() { Name = "Movie 8", Genre = "Drama", MpaaRating = MpaaRating.PG13, Rating = 5.5, ReleaseDate = DateTime.Now.AddYears(-10) },
        });

        db.SaveChanges();
    }
}
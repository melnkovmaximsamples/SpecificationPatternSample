using System.Linq.Expressions;
using SpecificationPatternOnExtensionsSample.Entities;

namespace SpecificationPatternOnExtensionsSample.Specifications;

public static class LinqMovieSpecifications
{
    public static IQueryable<Movie> IsSatisfiedByReleasedThisYear(this IQueryable<Movie> movie)
    {
        return movie.Where(x => true);
    }

    public static IQueryable<Movie> IsSatisfiedByGenreTriller(this IQueryable<Movie> movie)
    {
        return movie.Where(x => x.Genre == "Triller");
    }
    
    public static IQueryable<Movie> IsSatisfiedByReleasedFiveYearsAgoOrEarlier(this IQueryable<Movie> movie)
    {
        return movie.Where(x => DateTime.Now.Year - x.ReleaseDate.Year >= 5);
    }
}
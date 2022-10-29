using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc;
using SpecificationPatternOnExtensionsSample.Entities;
using SpecificationPatternOnExtensionsSample.Interfaces;
using SpecificationPatternOnExtensionsSample.Specifications;

namespace SpecificationPatternOnExtensionsSample.Controllers;

[ApiController]
[Route("[controller]")]
public class SpecificationsController : ControllerBase
{
    private readonly IMovieRepository _movieRepository;

    public SpecificationsController(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }
    
    [HttpGet("[action]")]
    public IEnumerable<Movie> GetMovieReleasedThisYear()
    {
        var func = LinqMovieSpecifications.IsSatisfiedByReleasedFiveYearsAgoOrEarlier;
        var specification = Expression.Lambda<Func<IQueryable<Movie>, IQueryable<Movie>>>(Expression.Call(func.Method));
        
        return _movieRepository.Find(specification);
    }

    [HttpGet("[action]")]
    public IEnumerable<Movie> GetMovieReleasedFiveYearsAgoOrEarlier()
    {
        var func = LinqMovieSpecifications.IsSatisfiedByReleasedFiveYearsAgoOrEarlier;
        var specification = Expression.Lambda<Func<IQueryable<Movie>, IQueryable<Movie>>>(Expression.Call(func.Method));

        return _movieRepository.Find(specification);
    }

    [HttpGet("[action]")]
    public IEnumerable<Movie> GetMovieReleasedThisYearWithGenreTriller()
    {
        var func = LinqMovieSpecifications.IsSatisfiedByReleasedFiveYearsAgoOrEarlier;
        var specification = Expression.Lambda<Func<IQueryable<Movie>, IQueryable<Movie>>>(Expression.Call(func.Method));

        return _movieRepository.Find(specification);
    }
}
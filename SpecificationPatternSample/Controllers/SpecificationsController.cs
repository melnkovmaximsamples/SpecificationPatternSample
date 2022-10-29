using Microsoft.AspNetCore.Mvc;
using SpecificationPatternSample.Entities;
using SpecificationPatternSample.Interfaces;
using SpecificationPatternSample.Specifications;
using SpecificationPatternSample.Specifications.ConcreteSpecifications;

namespace SpecificationPatternSample.Controllers;

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
        var movieReleasedThisYear = new MovieReleasedThisYear();

        return _movieRepository.Find(movieReleasedThisYear);
    }

    [HttpGet("[action]")]
    public IEnumerable<Movie> GetMovieReleasedFiveYearsAgoOrEarlier()
    {
        var movieReleasedFiveYearsAgoOrEarlier = new MovieReleasedFiveYearsAgoOrEarlier();

        return _movieRepository.Find(movieReleasedFiveYearsAgoOrEarlier);
    }

    [HttpGet("[action]")]
    public IEnumerable<Movie> GetMovieReleasedThisYearWithGenreTriller()
    {
        var movieReleasedThisYearWithGenreTriller = new MovieReleasedThisYear()
            .And(new MovieWithGenreTriller());

        return _movieRepository.Find(movieReleasedThisYearWithGenreTriller);
    }
}
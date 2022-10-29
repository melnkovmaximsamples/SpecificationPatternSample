using SpecificationPatternOnExtensionsSample.Enums;

namespace SpecificationPatternOnExtensionsSample.Entities;

public class Movie: EntityBase
{
    public string Name { get; set; }
    public DateTime ReleaseDate { get; set; }
    public MpaaRating MpaaRating { get; set; }
    public string Genre { get; set; }
    public double Rating { get; set; }
}
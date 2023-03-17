using System.ComponentModel.DataAnnotations;

namespace MovieApp.Models;

public class Movie
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Price { get; set; }

    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    public int CategoryId { get; set; }
    public Category? Category { get; set; }
}

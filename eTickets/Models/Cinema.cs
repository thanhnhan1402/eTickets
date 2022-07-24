using System.ComponentModel.DataAnnotations;

namespace eTickets.Models;

public class Cinema
{
    [Key]
    public int Id { get; set; }
    [Display(Name = "Cinema's Logo")]
    public string Logo { get; set; }
    [Display(Name = "Cinema's Name")]
    public string Name { get; set; }
    public string Description { get; set; }
    //Relationships
    public List<Movie> Movies { get; set; }
}

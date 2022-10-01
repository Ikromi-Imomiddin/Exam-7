using System.ComponentModel.DataAnnotations;

namespace Domain.Entites;

public class Challange
{
    public int Id { get; set; }
    [MaxLength(500), Required]
    public string? Title { get; set; }
    [MaxLength(500), Required]
    public string? Description { get; set; }


    public virtual List<Group> Groups { get; set; }
}

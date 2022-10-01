using System.ComponentModel.DataAnnotations;
namespace Domain.Entites;
public class Participant
{
    public int Id { get; set; }
    [Required, MaxLength(100)]
    public string? Fullname { get; set; }
    [Required, MaxLength(100)]
    public string? Email { get; set; }
    [Required, MaxLength(100)]
    public string? Phone { get; set; }
    [Required, MaxLength(100)]
    public string? Password { get; set; }
    [Required, MaxLength(100)]
    public string? CreatedAt { get; set; }
    [Required, MaxLength(100)]
    public int GroupId { get; set; }
    public virtual Group Group { get; set; }
    public int LocationId { get; set; }
    public virtual Location Location { get; set; }
}

using System.ComponentModel.DataAnnotations;
using Domain.Entites;

public class Group
{
    public int Id { get; set; }
    [Required,MaxLength(100)]
    public string? GroupNick { get; set; }
    [MaxLength(500), Required]
    public int ChallangeId { get; set; }
    public virtual Challange Chalange { get; set; }
    
    public bool NeededMember { get; set; }
    [MaxLength(500), Required]
    public string? TeamSlogan { get; set; }
    public string CreatedAt { get; set; }


    public virtual List<Participant> Participants { get; set; }
}
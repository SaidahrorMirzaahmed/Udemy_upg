using Udemy.Domain.Entites;

namespace Udemy.Services.DTOs.Cards;

public class CardView
{
    public int UserId { get; set; }
    public User User { get; set; }
    public decimal Balance { get; set; }
}

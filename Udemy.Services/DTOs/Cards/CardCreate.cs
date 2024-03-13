using Udemy.Domain.Entites;

namespace Udemy.Services.DTOs.Cards;

public class CardCreate
{
    public int UserId { get; set; }
    public User User { get; set; }
    public decimal Balance { get; set; }
}

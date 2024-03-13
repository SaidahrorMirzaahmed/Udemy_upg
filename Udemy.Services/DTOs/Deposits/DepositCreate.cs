using Udemy.Domain.Entites;

namespace Udemy.Services.DTOs.Deposits;

public class DepositCreate
{
    public decimal Amount { get; set; }
    public int CardId { get; set; }
    public Card Card { get; set; }
}

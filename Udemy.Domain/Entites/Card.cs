using Udemy.Domain.Commons;

namespace Udemy.Domain.Entites;

public class Card:Auditable
{
    public int UserId {  get; set; }
    public User User { get; set; }
    public decimal Balance {  get; set; }
}


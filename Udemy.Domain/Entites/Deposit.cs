using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Domain.Commons;

namespace Udemy.Domain.Entites;

public class Deposit:Auditable
{
    public decimal Amount { get; set; }
    public int CardId { get; set; }
    public Card Card { get; set; }
}
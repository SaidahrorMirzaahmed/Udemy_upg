using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Domain.Commons;

namespace Udemy.Domain.Entites;

public class BoughtCources:Auditable
{
    public int UserId {  get; set; }
    public User User { get; set; }
    public int CourceId {  get; set; }
    public Course Course { get; set; }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Domain.Commons;

namespace Udemy.Domain.Entites;

public class Course:Auditable
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }  
    public string Duration {  get; set; }
}

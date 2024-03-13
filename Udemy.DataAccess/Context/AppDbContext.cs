using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client.Platforms.Features.DesktopOs.Kerberos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.DataAccess.Credentials;
using Udemy.Domain.Entites;

namespace Udemy.DataAccess.Context;

public class AppDbContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString.connectionString1);
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Card> Cards { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Deposit> deposits { get; set; }
    public DbSet<BoughtCources> boughtCources { get; set; }
}

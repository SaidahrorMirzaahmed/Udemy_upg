using Udemy.Domain.Commons;

namespace Udemy.Domain.Entites;

public class User : Auditable
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string PhoneNumber { get; set; }

    public string Password { get; set; }
}

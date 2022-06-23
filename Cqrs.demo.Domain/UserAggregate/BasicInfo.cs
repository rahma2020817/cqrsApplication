namespace Cqrs.demo.Domain.UserAggregate;

public class BasicInfo
{
    public string FirstName { get; private set; } = default!;
    public string LastName { get; private set; } = default!;
    public string Email { get; private set; } = default!;
    public string Phone { get; private set; } = default!;
    public DateTime DateOfBirth { get; private set; }
    public string CurrentCity { get; private set; } = default!;

    private BasicInfo()
    {
        
    }
    public static BasicInfo Create(string firstName, string lastName, string email, string phone, DateTime dateOfBirth, string currentCity)
    {
        //TODO: implement validation errors handling
        return new BasicInfo
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            Phone = phone,
            DateOfBirth = dateOfBirth,
            CurrentCity = currentCity
        };

    }
}
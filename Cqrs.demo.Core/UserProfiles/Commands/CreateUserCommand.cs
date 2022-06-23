using Cqrs.demo.Domain.UserAggregate;
using MediatR;

namespace Cqrs.demo.Core.UserProfiles.Commands;

public class CreateUserCommand : IRequest<UserProfile>
{
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string Phone { get; set; } = default!;
    public DateTime DateOfBirth { get; set; }
    public string CurrentCity { get; set; } = default!;

}
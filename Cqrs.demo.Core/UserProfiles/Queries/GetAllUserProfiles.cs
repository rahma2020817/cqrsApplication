using Cqrs.demo.Domain.UserAggregate;
using MediatR;


namespace Cqrs.demo.Core.UserProfiles.Queries;

public class GetAllUserProfiles : IRequest<IEnumerable<UserProfile>>
{
    
}
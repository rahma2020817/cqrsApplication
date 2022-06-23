using Cqrs.demo.Core.Mapping;
using Cqrs.demo.Core.UserProfiles.Commands;
using Cqrs.demo.Domain.UserAggregate;
using Cqrs.demo.Infrastructure;
using MediatR;

namespace Cqrs.demo.Core.UserProfiles.CommandHandlers;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserProfile>
{
    public readonly PostContext _ctx;
    public readonly UserProfileMapper _Mapper;

    public CreateUserCommandHandler(PostContext ctx, UserProfileMapper mapper)
    {
        _ctx = ctx;
        _Mapper = mapper;
    }

    public async Task<UserProfile> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var userProfile = _Mapper.MapFormCreateUserCommandToUserProfile(request);

        _ctx.UserProfiles.Add(userProfile);
        await _ctx.SaveChangesAsync(cancellationToken);

        return userProfile;
    }
}
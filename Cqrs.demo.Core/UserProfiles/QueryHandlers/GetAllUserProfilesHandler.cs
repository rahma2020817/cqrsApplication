using Cqrs.demo.Core.UserProfiles.Queries;
using Cqrs.demo.Domain.UserAggregate;
using Cqrs.demo.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Cqrs.demo.Core.UserProfiles.QueryHandlers;

public class GetAllUserProfilesHandler : IRequestHandler<GetAllUserProfiles, IEnumerable<UserProfile>>
{
    private readonly PostContext _ctx;

    public GetAllUserProfilesHandler(PostContext ctx)
    {
        _ctx = ctx;
    }

    public async Task<IEnumerable<UserProfile>> Handle(GetAllUserProfiles request, CancellationToken cancellationToken)
    {
        var profiles = await _ctx.UserProfiles.ToListAsync();

        return profiles;
    }
}
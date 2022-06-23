using Cqrs.demo.Core.Mapping;
using Cqrs.demo.Core.Models.UserProfile.Requests;
using Cqrs.demo.Core.UserProfiles.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Cqrs.demo.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserProfileController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly UserProfileMapper _mapper;
    public UserProfileController(IMediator mediator, UserProfileMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllProfiles()
    {
        var query = new GetAllUserProfiles();
        var profiles = await _mediator.Send(query);
        var response = profiles.Select(_mapper.MapFormUserProfileToCreatedUserProfile).ToList();
        //var profiles = _mapper.MapFormUserProfileToCreateUserCommand(response)
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> CreateUserProfile([FromBody] UserProfileCreate profile)
    {
        var command = _mapper.MapFromUserProfileCommandToUserProfileCreate(profile);
        var response = await _mediator.Send(command);
        var userProfile = _mapper.MapFormUserProfileToCreatedUserProfile(response);
        return Ok(userProfile.UserProfileId);
    }
    
    
}
using Cqrs.demo.Core.Models.UserProfile.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Cqrs.demo.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserProfileController : ControllerBase
{
    private readonly IMediator _mediator;
    public UserProfileController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllProfiles()
    {
        return (IActionResult)Task.FromResult(Ok());
    }

    [HttpPost]
    public async Task<IActionResult> CreateUserProfile([FromBody] UserProfileCreate profile)
    {
        
        return (IActionResult)Task.FromResult(Ok());
    }
    
    
}
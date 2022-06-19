using Cqrs.demo.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cqrs.demo.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PostsController : ControllerBase
{

    [HttpGet]
    [Route("id")]
    public ActionResult<PostDto> GetById(int id)
    {
        var post = new PostDto { Id = id, Text = "hello" };
        return Ok(post);
    }
}
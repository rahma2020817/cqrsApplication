namespace Cqrs.demo.Core.Models;

public class PostDto
{
    public PostDto(int id, string text)
    {
        Id = id;
        Text = text;
    }

    public PostDto()
    {
       
    }

    public int Id { get; set; }
    public string Text { get; set; } = default!;
    
    
}
namespace Cqrs.demo.Domain;

public class Post
{
    public int Id { get; set; }
    public string Text { get; private set; } = default!;

    public Post()
    {
    }

    public Post(string text)
    {
        Text = text;
    }
}
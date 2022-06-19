using Cqrs.demo.Domain.UserAggregate;

namespace Cqrs.demo.Domain.PostAggregate;

public class Post
{
    private readonly List<PostComment> _comments = new List<PostComment>();
    private readonly List<PostInteraction> _interactions = new List<PostInteraction>();

    public Guid PostId { get; private set; }
    public Guid UserProfileId { get; private set; } = default!;
    
    public UserProfile UserProfile { get; private set; } = default!;
    public string TextContent { get; private set; } = default!;
    public DateTime CreatedDate { get; set; } = default!;
    public DateTime LastModified { get; set; } = default!;
    public IEnumerable<PostComment> Comments 
    {
        get { return _comments; }
    }
    public IEnumerable<PostInteraction> Interactions
    {
        get { return _interactions; }
    }

    public Post()
    {
    }

    public static Post Create(Guid userProfileId, string textContent)
    {
        return new Post
        {
            UserProfileId = userProfileId,
            TextContent = textContent,
            CreatedDate = DateTime.UtcNow,
            LastModified = DateTime.UtcNow
        };
    }

    public void UpdatePostText(string newText)
    {
        TextContent = newText;
        LastModified = DateTime.UtcNow;
    }


    public void AddComment(PostComment newComment)
    {
        _comments.Add(newComment);
    }

    public void RemoveComment(PostComment commentToRemove)
    {
        _comments.Remove(commentToRemove);
    }

    public void AddInteraction(PostInteraction newInteraction)
    {
        _interactions.Add(newInteraction);
    }

    public void InteractionToRemove(PostInteraction interactionToRemove)
    {
        _interactions.Remove(interactionToRemove);
    }
    
}
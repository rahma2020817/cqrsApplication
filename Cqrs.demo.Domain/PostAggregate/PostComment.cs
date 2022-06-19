namespace Cqrs.demo.Domain.PostAggregate;

public class PostComment
{
    public Guid CommentId { get; private set; }
    public Guid PostId { get; private set; }
    public string Text { get; private set; } = default!;
    public Guid UserProfileId { get; private set; }
    
    public DateTime CreatedDate { get;  private set; }
    public DateTime LastModified { get; private set; }

    public PostComment Create(Guid postId, string? text, Guid userProfileId)
    {
        return new PostComment
        {
            PostId = postId,
            Text = text,
            UserProfileId = userProfileId
        };
        
    }

    public void UpdateTextComment(string newText)
    {
        Text = newText;
        LastModified = DateTime.UtcNow;
    }
    
    

    
    
}
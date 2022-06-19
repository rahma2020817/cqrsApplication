namespace Cqrs.demo.Domain.PostAggregate;

public class PostInteraction
{
    public Guid InteractionId { get; private set; }
    public Guid PostId { get; private set; }
    public InteractionType InteractionType { get; private set; }

    private PostInteraction()
    {
        
    }
    public PostInteraction Create(InteractionType interactionType)
    {
        return new PostInteraction
        {
            InteractionType = interactionType
        };
    }
}
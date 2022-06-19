namespace Cqrs.demo.Domain.UserAggregate;

public class UserProfile
{
    public Guid UserProfileId { get; private set; }
    public string IdentityId { get; private set; } = default!;
    public BasicInfo BasicInfo { get; private set; }

    public DateTime CreatedDate { get;  private set; }

    public DateTime LastModified { get; private set; }

    private UserProfile()
    {
    }

    private UserProfile( string identityId, BasicInfo basicInfo)
    {
        IdentityId = identityId;
        BasicInfo = basicInfo;
        CreatedDate = DateTime.UtcNow;
        LastModified = DateTime.UtcNow;
    }

    public static UserProfile Create(string identityId, BasicInfo basicInfo)
    {
        // TODO: add validation, error handling strategies
        return new UserProfile(identityId, basicInfo);
    }

    public void UpdateBasicInfo(BasicInfo newInfo)
    {
        BasicInfo = newInfo;
        LastModified = DateTime.UtcNow;
    }
}
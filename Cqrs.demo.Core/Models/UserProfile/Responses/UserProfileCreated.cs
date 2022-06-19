using Swashbuckle.AspNetCore.Annotations;

namespace Cqrs.demo.Core.Models.UserProfile.Responses;

public class UserProfileCreated
{
    [SwaggerSchema("User Profile", ReadOnly = false, Nullable = false)]
    public string UserProfileId { get; set; }
    [SwaggerSchema("Basic Information", ReadOnly = false, Nullable = false)]
    public BasicInfoDto BasicInfo { get; set; }

}
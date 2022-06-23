using Cqrs.demo.Core.Contracts;
using Cqrs.demo.Core.Models.UserProfile.Requests;
using Cqrs.demo.Core.Models.UserProfile.Responses;
using Cqrs.demo.Core.UserProfiles.Commands;
using Cqrs.demo.Domain.UserAggregate;

namespace Cqrs.demo.Core.Mapping;

public class UserProfileMapper  : IPostMapper
{
    public CreateUserCommand MapFromCreateUserCommandToBasicInfo(BasicInfo basicInfo)
    {
        return new CreateUserCommand()
        {
            FirstName = basicInfo.FirstName,
            CurrentCity = basicInfo.CurrentCity,
            DateOfBirth = basicInfo.DateOfBirth,
            Email = basicInfo.Email,
            LastName = basicInfo.LastName,
            Phone = basicInfo.Phone
        };
    }

    public UserProfile MapFormCreateUserCommandToUserProfile(CreateUserCommand command)
    {
        var basicInfo = BasicInfo.Create(
            command.FirstName,
            command.LastName,
            command.Email,
            command.Phone,
            command.DateOfBirth,
            command.CurrentCity);
        return UserProfile.Create(Guid.NewGuid().ToString(), basicInfo);
    }


    public CreateUserCommand MapFromUserProfileCommandToUserProfileCreate(UserProfileCreate basicInfo)
    {
        var response = new CreateUserCommand
        {
            CurrentCity = basicInfo.CurrentCity,
            DateOfBirth = basicInfo.DateOfBirth,
            Email = basicInfo.Email,
            FirstName = basicInfo.FirstName,
            LastName = basicInfo.LastName,
            Phone = basicInfo.Phone
        };
        return response;
    }
    
    public UserProfileCreated MapFormUserProfileToCreatedUserProfile(UserProfile userProfile)
    {
        var response = new UserProfileCreated
        {
            UserProfileId = userProfile.UserProfileId.ToString(),
            BasicInfo = MapFromBasicInfoDtoToBasic(userProfile.BasicInfo)
        };
        return response;
    }

    public BasicInfoDto MapFromBasicInfoDtoToBasic(BasicInfo basicInfo)
    {
        var res = new BasicInfoDto
        {
            CurrentCity = basicInfo.CurrentCity,
            DateOfBirth = basicInfo.DateOfBirth,
            Email = basicInfo.Email,
            FirstName = basicInfo.FirstName,
            LastName = basicInfo.LastName,
            Phone = basicInfo.Phone
        };

        return res;
    }
    
}
﻿using Cqrs.demo.Core.Models.UserProfile.Responses;
using Swashbuckle.AspNetCore.Annotations;

namespace Cqrs.demo.Core.Models.UserProfile.Requests;

public class UserProfileCreate
{
    public string FirstName { get;  set; } = default!;
    public string LastName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string Phone { get; set; } = default!;
    public DateTime DateOfBirth { get; set; }
    public string CurrentCity { get; set; } = default!;

}
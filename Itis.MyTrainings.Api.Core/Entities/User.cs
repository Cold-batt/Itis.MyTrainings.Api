﻿using System.ComponentModel.DataAnnotations;
using Itis.MyTrainings.Api.Core.Abstractions;
using Itis.MyTrainings.Api.Core.Exceptions;
using Microsoft.AspNetCore.Identity;

namespace Itis.MyTrainings.Api.Core.Entities;

/// <summary>
/// Пользователь
/// </summary>
public class User: IdentityUser<Guid>, IEntity
{
    //private UserProfile _userProfile;
    
    /// <summary>
    /// Имя пользователя
    /// </summary>
    [Required]
    public string FirstName { get; set; } = default!;
        
    /// <summary>
    /// Фамилия пользователя
    /// </summary>
    [Required]
    public string LastName { get; set; } = default!;
    //
    // /// <summary>
    // /// Id профиля пользователя
    // /// </summary>
    // public Guid UserProfileId { get; set; }
    
}
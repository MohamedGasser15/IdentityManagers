﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace IdentityManagers.Models
{
    public class ApplicationUser :IdentityUser
    {
        [Required]
        public int Name { get; set; }
    }
}

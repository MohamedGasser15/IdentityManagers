using IdentityManagers.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace IdentityManagers.Data
{
    public class ApplicationDbContext :IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {
        }
        //Adding DbSet For Each Entity Type 
        public DbSet<ApplicationUser> ApplicationUser { get; set; } 
    }
}

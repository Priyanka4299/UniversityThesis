using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UniversityThesis.Models;

namespace UniversityThesis.Data
{
    public class ApplicationDbContext
        : IdentityDbContext<MyIdentityUser,MyIdentityRole, Guid>
    {
    
        public DbSet<Faculty> Faculty { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Subject> Subject { get; set; }

        public DbSet<UserInfo> UserInfo { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
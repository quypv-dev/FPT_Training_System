﻿using FPT_Training_System.ViewModels;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace FPT_Training_System.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public ManagerStaffViewModel managerStaffViewModels { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<CourseCategory> CourseCategories { get; set; }

        public DbSet<TrainerTopic> TrainerTopics { get; set; }
        public DbSet<TraineeCourse> TraineeCourses { get; set; }


        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

     
    }
}
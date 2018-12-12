using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using _403Project1.Models;

namespace _403Project1.DAL
{
    public class LearningDynamicsContext : DbContext
    {
        public LearningDynamicsContext() :
            base("LearningDynamicsContext")
        {

        }

        public DbSet<Parent> Parent { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<SchoolQuestion> SchoolQuestions { get; set; }
        public DbSet<School> School { get; set; }
    }
}
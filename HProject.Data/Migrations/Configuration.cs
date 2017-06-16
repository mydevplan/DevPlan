namespace HProject.Data.Migrations
{
    using HProject.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProjectManagementContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProjectManagementContext context)
        {

            // create projects
            context.ProjectSet.AddOrUpdate(GenerateProjects());

            // create roles
            context.RoleSet.AddOrUpdate(r => r.Name, GenerateRoles());

            context.UserSet.AddOrUpdate(u => u.Email, new User[]{
                new User()
                {
                    Email="myemail@gmail.com",
                    Username="admin",
                    HashedPassword ="u+Xjn28cGq3O0CcTp55a763mo2Jw8J7/DQq/u4nTbrU=",
                    Salt = "i4VZ2je0OvOUsowy8JdGIQ==",
                    IsLocked = false,
                    DateCreated = DateTime.Now
                }
            });

            // // create user-admin for chsakell
            context.UserRoleSet.AddOrUpdate(new UserRole[] {
                new UserRole() {
                    RoleId = 1, // admin
                    UserId = 1  // chsakell
                }
            });
        }



        private Project[] GenerateProjects()
        {
            List<Project> _projects = new List<Project>();

            _projects.Add(
                new Project()
                {
                    ProjectName = "Hitachi GC Services",
                    ProjectManager = "Kin Pang",
                    Email = "admin@gcservices.com",
                    ProjectEstimatedStartDate = new DateTime(2015, 08, 01),
                    ProjectEstimatedEndDate = new DateTime(2017, 08, 30),
                    ProjectActualStartDate = new DateTime(2015, 09, 01),
                    ProjectActualEndDate = new DateTime(2017, 08, 30),
                    CreatedDate=DateTime.Now
                });

            _projects.Add(
                 new Project()
                 {
                     ProjectName = "PPG Express Project",
                     ProjectManager = "Madhusudan Kaspa",
                     Email = "ppg@ppgexpress.com",
                     ProjectEstimatedStartDate = new DateTime(2017, 04, 01),
                     ProjectEstimatedEndDate = new DateTime(2017, 08, 30),
                     ProjectActualStartDate = new DateTime(2017, 04, 01),
                     ProjectActualEndDate = new DateTime(2019, 08, 30),
                     CreatedDate = DateTime.Now,
                 });


            return _projects.ToArray();
        }
        private Role[] GenerateRoles()
        {
            Role[] _roles = new Role[]{
                new Role()
                {
                    Name="Admin"
                }
            };

            return _roles;
        }
       
    }
}

using HProject.Entities;
using HProject.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HProject.Web.Infrastructure.Extensions
{
    public static class EntitiesExtensions
    {

        public static void UpdateProject(this Project project, ProjectViewModel projectVm)
        {
            project.ProjectName = projectVm.ProjectName;
            project.ProjectManager = projectVm.ProjectManager;
            project.ProjectEstimatedStartDate = projectVm.ProjectEstimatedStartDate;
            project.ProjectEstimatedEndDate = projectVm.ProjectEstimatedEndDate;
            project.ProjectActualStartDate = (projectVm.ProjectActualStartDate.HasValue ?  projectVm.ProjectActualStartDate: null);
            project.ProjectActualEndDate = (projectVm.ProjectActualEndDate.HasValue ? projectVm.ProjectActualEndDate : null);
            project.Email = projectVm.Email;
            project.CreatedDate = DateTime.Now;


        }
    }
}
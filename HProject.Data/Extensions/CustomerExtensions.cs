using HProject.Data.Repositories;
using HProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HProject.Data.Extensions
{
    public static class CustomerExtensions
    {
        public static bool UserExists(this IEntityBaseRepository<Project> projectsRepository, string email)
        {
            bool _userExists = false;

            _userExists = projectsRepository.GetAll()
                .Any(c => c.Email.ToLower() == email);

            return _userExists;
        }

        public static string GetProjectFullName(this IEntityBaseRepository<Project> projectsRepository, int projectId)
        {
            string _projectName = string.Empty;

            var _project = projectsRepository.GetSingle(projectId);

            _projectName = _project.ProjectName;

            return _projectName;
        }
    }
}

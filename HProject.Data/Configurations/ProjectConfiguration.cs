using HProject.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HProject.Data.Configurations
{
    public class ProjectConfiguration : EntityBaseConfiguration<Project>
    {
        public ProjectConfiguration()
        {
            Property(u => u.ProjectName).IsRequired().HasMaxLength(100);
            Property(u => u.ProjectManager).IsRequired().HasMaxLength(75);
            Property(u => u.CreatedDate).IsOptional();
            Property(c => c.ProjectEstimatedStartDate).IsRequired();
            Property(c => c.ProjectEstimatedEndDate).IsRequired();
            Property(c => c.ProjectActualStartDate).IsOptional();
            Property(c => c.ProjectActualEndDate).IsOptional();
            Property(c => c.Email).IsRequired().HasMaxLength(200);
        }
    }
}

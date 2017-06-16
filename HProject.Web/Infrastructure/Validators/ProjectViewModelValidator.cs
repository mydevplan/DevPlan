using FluentValidation;
using HProject.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HProject.Web.Infrastructure.Validators
{
    public class ProjectViewModelValidator : AbstractValidator<ProjectViewModel>
    {
        public ProjectViewModelValidator()
        {
            RuleFor(project => project.ProjectName).NotEmpty()
                .Length(1, 100).WithMessage("Project Name must be between 1 - 100 characters");

            RuleFor(project => project.ProjectManager).NotEmpty()
                .Length(1, 100).WithMessage("Manager Name must be between 1 - 50 characters");

            RuleFor(project => project.ProjectEstimatedStartDate).NotNull()
                .WithMessage("Project should have Estimated start date.");

            RuleFor(project => project.ProjectEstimatedEndDate).NotNull()
               .WithMessage("Project should have Estimated End date.");

            RuleFor(project => project.Email).NotEmpty().EmailAddress()
                .WithMessage("Enter a valid Email address");

            RuleFor(m => m.ProjectEstimatedStartDate).NotEmpty().LessThan(m => m.ProjectEstimatedEndDate)
                .WithMessage("Estimated Start date must be less than Estimated End date");

            RuleFor(m => m.ProjectActualStartDate).NotEmpty().LessThan(m => m.ProjectActualEndDate)
               .WithMessage("Actual Start date must be less than Actual End date").When(m => m.ProjectActualEndDate.HasValue);

        }
    }
}
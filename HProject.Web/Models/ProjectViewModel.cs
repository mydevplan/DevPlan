using HProject.Web.Infrastructure.Validators;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HProject.Web.Models
{
    [Bind(Exclude = "UniqueKey")]
    public class ProjectViewModel : IValidatableObject
    {
        public int ID { get; set; }
        public string ProjectName { get; set; }
        public string ProjectManager { get; set; }

        public Nullable<DateTime> CreatedDate { get; set; }
        public DateTime ProjectEstimatedStartDate { get; set; }
        public DateTime ProjectEstimatedEndDate { get; set; }

        public Nullable<DateTime> ProjectActualStartDate { get; set; }
        public Nullable<DateTime> ProjectActualEndDate { get; set; }

        public string Email { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validator = new ProjectViewModelValidator();
            var result = validator.Validate(this);
            return result.Errors.Select(item => new ValidationResult(item.ErrorMessage, new[] { item.PropertyName }));
        }
    }
}
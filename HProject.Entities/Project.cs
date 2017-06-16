using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HProject.Entities
{
    /// <summary>
    /// Project Info
    /// </summary>
    public class Project : IEntityBase
    {
        public int ID { get; set; }
        public string ProjectName { get; set; }
        public string ProjectManager { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ProjectEstimatedStartDate { get; set; }
        public DateTime ProjectEstimatedEndDate { get; set; }

        public Nullable<DateTime> ProjectActualStartDate { get; set; }
        public Nullable<DateTime> ProjectActualEndDate { get; set; }

        public string Email { get; set; }
       
       
    }
}

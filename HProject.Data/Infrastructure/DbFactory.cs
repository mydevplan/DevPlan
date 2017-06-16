using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HProject.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        ProjectManagementContext dbContext;

        public ProjectManagementContext Init()
        {
            return dbContext ?? (dbContext = new ProjectManagementContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}

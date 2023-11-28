using Microsoft.EntityFrameworkCore;
using Phase3Endproject.Model;

namespace Phase3Endproject.Database
{
    public class ApplicationDbcontext:DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext>options):base(options)
        {
            
        }

        public DbSet<EmpProfile> EmpProfiles { get; set; } = default!;
        public DbSet<DeptMaster> DeptMasters { get; set;}


    }
}

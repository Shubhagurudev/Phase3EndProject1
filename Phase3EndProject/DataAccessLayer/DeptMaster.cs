using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    [Table("Emp")]
    public class EmpProfile
    {

        [Key]
        public int EmpCode { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EmpName { get; set; }
        public string Email { get; set; }
        public int DeptCode { get; set; }
        public virtual DeptMaster DeptMaster { get; set; }
    }
    public class DeptMaster
    {
        [Key]
        public int DeptCode { get; set; }
        public string DeptName { get; set; }
        public virtual ICollection<EmpProfile> EmpProfiles { get; set; }
    }

    public class EmsContext : DbContext
    {
        public EmsContext() : base("name= EmsContext")
        {
            Database.SetInitializer<EmsContext>(new DropCreateDatabaseIfModelChanges<EmsContext>());

        }
        public DbSet<EmpProfile> EmpProfiles { get; set; }
        public DbSet<DeptMaster> DeptMasters { get; set; }
    }

    public class EmsInitializer : DropCreateDatabaseIfModelChanges<EmsContext>
    {
        protected override void Seed(EmsContext context)
        {
            base.Seed(context);
            DeptMaster d1 = new DeptMaster { DeptCode = 1, DeptName = "HR" };
            DeptMaster d2 = new DeptMaster { DeptCode = 2, DeptName = "Management" };
            context.DeptMasters.Add(d1);
            context.SaveChanges();
            context.DeptMasters.Add(d2);
            context.SaveChanges();
            EmpProfile empProfile = new EmpProfile { EmpCode = 101, DateOfBirth = new DateTime(2000, 01, 10), EmpName = "Smruthi", Email = "smruthi123@gmail.com", DeptCode = 1 };
            context.EmpProfiles.Add(empProfile);
            context.SaveChanges();
        }
    }
}

using MemberRegistration.DataAccess.Concrete.EntityFramework.Mappings;
using MemberRegistration.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.DataAccess.Concrete.EntityFramework
{
   public class MemberShipContext:DbContext
    {
        public MemberShipContext()
        {
            Database.SetInitializer<MemberShipContext>(null);
        }
        public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MemberMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}

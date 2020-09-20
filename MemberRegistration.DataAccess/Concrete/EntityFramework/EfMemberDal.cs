using DevFramework.Core.DataAccess.EntityFramework;
using MemberRegistration.DataAccess.Abstract;
using MemberRegistration.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.DataAccess.Concrete.EntityFramework
{
   public class EfMemberDal:EfEntityRepositoryBase<Member,MemberShipContext>,IMemberDal
    {

    }
}

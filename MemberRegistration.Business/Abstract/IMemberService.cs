using MemberRegistration.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.Business.Abstract
{
   public interface IMemberService
    {
        List<Member> GetMembers();

        Member GetById(int id);

        void Add(Member entity);

        void Update(Member entity);

        void Delete(Member entity);

    }
}

using MemberRegistration.Business.Abstract;
using MemberRegistration.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.ConsoleUI
{
   public class Adding
    {
        IMemberService _memberService;
        public Adding(IMemberService memberService)
        {
            _memberService = memberService;
        }
       
    }
}

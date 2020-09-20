using FluentValidation;
using MemberRegistration.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.Business.ValidationRules.FluentValidation
{
   public class MemberValidator:AbstractValidator<Member>
    {
        public MemberValidator()
        {
           
            RuleFor(p => p.TcNo).NotEmpty();
            RuleFor(p => p.Password).NotEmpty();

        }
                    
    }
}

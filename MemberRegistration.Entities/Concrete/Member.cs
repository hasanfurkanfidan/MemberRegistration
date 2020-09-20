
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.Entities.Concrete
{
   public class Member:IEntity
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string LastName { get; set; }

        public string Password { get; set; }

        public string TCNo { get; set; }

        public string EMail { get; set; }
    }
}

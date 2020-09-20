using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemberRegistration.MVC.Models.ViewModels
{
    public class MemberAddingViewModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EMail { get; set; }

        public string Password { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string TC { get; set; }
    }
}
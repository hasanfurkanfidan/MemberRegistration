using MemberRegistration.Business.Abstract;
using MemberRegistration.Business.DependencyResolvers.Ninject;
using MemberRegistration.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.ConsoleUI
{ 
    class Program
    {
        IMemberService _memberService;
        public Program(IMemberService memberService)
        {
            _memberService = memberService;    
        }
        static void Main(string[] args)
        {
            string FirstName;
            string LastName;
            string Tc;
            string Email;
            string Password;
            DateTime DateOfBirth;
            Console.WriteLine("Lütfen adınızı giriniz:");
            FirstName =  Console.ReadLine();
            Console.WriteLine("Lütfen Soyadınızı  giriniz:");
            LastName = Console.ReadLine();
            Console.WriteLine("Tc no ");
            Tc = Console.ReadLine();
            Console.WriteLine("dOGUM");
            DateOfBirth = Convert.ToDateTime(  Console.ReadLine());
            Console.WriteLine("Email");
            Email = Console.ReadLine();
            Console.WriteLine("Password");
            Password = Console.ReadLine();
            var memberService = InstanceFactory<IMemberService>.GetInstance<IMemberService>();
            memberService.Add(new Member { DateOfBirth = DateOfBirth, Email = Email, TcNo = Tc, FirstName = FirstName, LastName = LastName, Password = Password });
            Console.WriteLine("Eklendi");
            Console.ReadLine();
            

        }
      
         
        
    }
}

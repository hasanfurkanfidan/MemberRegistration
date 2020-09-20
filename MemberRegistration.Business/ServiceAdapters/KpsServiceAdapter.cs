using MemberRegistration.Business.KpsServiceReference;
using MemberRegistration.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.Business.ServiceAdapters
{
    public class KpsServiceAdapter : IKpsService
    {

        public bool ValidateUser(Member member)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            if (client.TCKimlikNoDogrula(long.Parse(member.TcNo), member.FirstName, member.LastName, member.DateOfBirth.Year))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

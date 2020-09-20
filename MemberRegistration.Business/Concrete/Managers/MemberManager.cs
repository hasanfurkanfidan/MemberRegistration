using DevFramework.Core.Aspects.PostSharp.ValidationAspects;
using DevFramework.Core.Utilities.WebApi;
using MemberRegistration.Business.Abstract;
using MemberRegistration.Business.ServiceAdapters;
using MemberRegistration.Business.ValidationRules.FluentValidation;
using MemberRegistration.DataAccess.Abstract;
using MemberRegistration.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.Business.Concrete.Managers
{
    public class MemberManager : IMemberService
    {
       private readonly IMemberDal _memberDal;
       private readonly IKpsService _kpsService;
        public MemberManager(IMemberDal memberDal,IKpsService kpsService)
        {
            _kpsService = kpsService;
            _memberDal = memberDal;
        }
        [FluentValidationAspect(typeof(MemberValidator))]
        public void Add(Member entity)
        {
            CheckMemberExist(entity);
            CheckValidators(entity);
            _memberDal.Add(MapperHelper.MapToSameType(entity));


        }

        public void Delete(Member entity)
        {
            _memberDal.Delete(MapperHelper.MapToSameType(entity));
        }

        public Member GetById(int id)
        {
            return MapperHelper.MapToSameType(_memberDal.Get(p => p.Id == id));

        }

        public List<Member> GetMembers()
        {
            return MapperHelper.MapToSameType(_memberDal.GetList());
        }

        public void Update(Member entity)
        {
            if (_memberDal.Get(p => p.TcNo == entity.TcNo) == null)
            {
                if (_kpsService.ValidateUser(entity))
                {
                    _memberDal.Update(MapperHelper.MapToSameType(entity));
                }
            }
           
        }
        private void CheckMemberExist(Member member)
        {
            if (_memberDal.Get(m => m.TcNo == member.TcNo) != null)
            {
                throw new Exception("Bilgilerinizi kontrol ediniz");
            }
        }
        private void CheckValidators(Member member)
        {
            if (!_kpsService.ValidateUser(member))
            {
                throw new Exception("Bilgilerinizi kontrol ediniz");
            }
        }
    }
}

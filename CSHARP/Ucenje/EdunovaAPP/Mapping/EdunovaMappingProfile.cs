using AutoMapper;
using EdunovaAPP.Models;
using EdunovaAPP.Models.DTO;

namespace EdunovaAPP.Mapping
{
    public class EdunovaMappingProfile:Profile
    {
        public EdunovaMappingProfile()
        {
            // kreiramo mapiranja: izvor, odredište
            CreateMap<Smjer, SmjerDTORead>();
            CreateMap<SmjerDTORead, Smjer>();
            CreateMap<SmjerDTOInsertUpdate, Smjer>();

            CreateMap<Polaznik, PolaznikDTORead>();
            CreateMap<PolaznikDTORead, Polaznik>();
            CreateMap<PolaznikDTOInsertUpdate, Polaznik>();

        }
    }
}

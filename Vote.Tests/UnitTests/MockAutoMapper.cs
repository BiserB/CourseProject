using AutoMapper;
using Vote.Services.Manager.MapperProfile;

namespace Vote.Tests.UnitTests
{
    public static class MockAutoMapper
    {
        static MockAutoMapper()
        {
            AutoMapper.Mapper.Initialize(opt => opt.AddProfile<ManagerAutoMapperProfile>());
        }

        public static IMapper GetAutoMapper()
        {
            return Mapper.Instance;
        }
    }
}
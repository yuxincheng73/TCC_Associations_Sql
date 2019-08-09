using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TCCAssociation.Authorization;

namespace TCCAssociation
{
    [DependsOn(
        typeof(TCCAssociationCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TCCAssociationApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TCCAssociationAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TCCAssociationApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}

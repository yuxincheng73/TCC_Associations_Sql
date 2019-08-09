using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TCCAssociation.Configuration;

namespace TCCAssociation.Web.Host.Startup
{
    [DependsOn(
       typeof(TCCAssociationWebCoreModule))]
    public class TCCAssociationWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TCCAssociationWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TCCAssociationWebHostModule).GetAssembly());
        }
    }
}

using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace TCCAssociation.Controllers
{
    public abstract class TCCAssociationControllerBase: AbpController
    {
        protected TCCAssociationControllerBase()
        {
            LocalizationSourceName = TCCAssociationConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

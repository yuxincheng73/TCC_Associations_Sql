using Microsoft.AspNetCore.Antiforgery;
using TCCAssociation.Controllers;

namespace TCCAssociation.Web.Host.Controllers
{
    public class AntiForgeryController : TCCAssociationControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}

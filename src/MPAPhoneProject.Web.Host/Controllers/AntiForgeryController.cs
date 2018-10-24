using Microsoft.AspNetCore.Antiforgery;
using MPAPhoneProject.Controllers;

namespace MPAPhoneProject.Web.Host.Controllers
{
    public class AntiForgeryController : MPAPhoneProjectControllerBase
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

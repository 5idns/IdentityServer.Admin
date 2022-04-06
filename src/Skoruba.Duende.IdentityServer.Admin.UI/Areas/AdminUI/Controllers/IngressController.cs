using Duende.IdentityServer.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Skoruba.Duende.IdentityServer.Admin.UI.Areas.AdminUI.Controllers
{
    public class IngressController : BaseController
    {
        public IngressController(ILogger<IngressController> logger) : base(logger)
        {
        }

        [HttpGet]
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return Json(new
                {
                    authenticated = true,
                    user = User.GetDisplayName()
                });
            }
            return Json(new
            {
                authenticated = false,
                user = ""
            });
        }
    }
}

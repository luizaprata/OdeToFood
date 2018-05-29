using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    [Route("company/[controller]/[action]")]
    public class AboutController
    {
        public string Phone()
        {
            return "00 00000-0000";
        }

        public string Address()
        {
            return "BR";
        }
    }
}

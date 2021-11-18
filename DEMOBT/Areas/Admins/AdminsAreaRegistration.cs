using System.Web.Mvc;

namespace DEMOBT.Areas.Admins
{
    public class AdminsAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admins";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admins_default",
                "Admins/{controller}/{action}/{id}",
                new { area ="Admins", controller ="Home_Ad", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
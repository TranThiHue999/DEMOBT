using System.Web.Mvc;

namespace DEMOBT.Areas.NhanVien
{
    public class NhanVienAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "NhanVien";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "NhanVien_default",
                "NhanVien/{controller}/{action}/{id}",
                new { area = "NhanVien", controller = "HomeNV", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
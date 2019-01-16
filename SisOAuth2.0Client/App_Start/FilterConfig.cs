using System.Web;
using System.Web.Mvc;

namespace SisOAuth2._0Client
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            GlobalFilters.Filters.Add(new RequireHttpsAttribute());
        }
    }
}

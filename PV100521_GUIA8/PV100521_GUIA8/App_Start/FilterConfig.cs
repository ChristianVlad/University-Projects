using System.Web;
using System.Web.Mvc;

namespace PV100521_GUIA8
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

using System.Web;
using System.Web.Mvc;

namespace LABORATORIO03_PV100521
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

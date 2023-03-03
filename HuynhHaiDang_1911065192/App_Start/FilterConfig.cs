using System.Web;
using System.Web.Mvc;

namespace TranCongMinh_1911060177
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

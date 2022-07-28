using System.Web;
using System.Web.Mvc;

namespace Eclerx.Program3.RupaliDound
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

using System.Web;
using System.Web.Mvc;

namespace Information_and_Technology_College
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

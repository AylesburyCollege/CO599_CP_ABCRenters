using System.Web;
using System.Web.Mvc;

namespace CO599_CP_ABCRenters
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

using System.Web;
using System.Web.Mvc;

namespace HR_Lesson2_Fall_2011.web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
using System.Web;
using System.Web.Mvc;

namespace HAN.OOSE.Semesterbeheer.Applicatie
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

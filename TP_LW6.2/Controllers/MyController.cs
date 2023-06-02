using System.Web.Mvc;
using System.Web.Routing;

namespace TP_LW6._2.Controllers
{
    public class MyController : IController
    {
        public void Execute(RequestContext requestContext)
        {
            if (requestContext.RouteData.Values["action"].Equals("Start") &&
                requestContext.RouteData.Values["id"].Equals("0"))
            {
                requestContext.HttpContext.Response.Redirect("/Home/Index", true);
                return;
            }

            requestContext.HttpContext.Response.Write(
                $"<h2>Неверные параметры Action и Id<br/>{requestContext.HttpContext.Request.Url}</h2>");
        }
    }
}
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static string IsSelected(this IHtmlHelper htmlHelper, string controllers, string actions, string cssClass = "active")
        {
            string currentAction = htmlHelper.ViewContext.RouteData.Values["action"] as string;
            string currentController = htmlHelper.ViewContext.RouteData.Values["controller"] as string;
            if (currentController == null || currentAction == null) return "";
            IEnumerable<string> acceptedActions = (actions ?? currentAction).Split(',');
            IEnumerable<string> acceptedControllers = (controllers ?? currentController).Split(',');
            string result = String.Empty;
            if (acceptedControllers?.Any() == true)
            {
                result = acceptedActions.Contains(currentAction) &&
                    acceptedControllers.Contains(currentController) ?
                    cssClass : String.Empty;
            }
            else
            {
                result = acceptedActions.Contains(currentAction) ?
                cssClass : String.Empty;
            }


            return result;
        }
    }
}

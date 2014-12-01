using System.Web.Mvc;
using Bs.Models;

namespace Bs
{
    public static partial class BsExtensions
    {
        public static MvcHtmlString Button(this HtmlHelper helper)
        {
            return new MvcHtmlString("");            
        }

        public static MvcHtmlString Button(this HtmlHelper helper, ButtonModel model)
        {
            return new MvcHtmlString("");
        }

        //buttonfor
    }
}

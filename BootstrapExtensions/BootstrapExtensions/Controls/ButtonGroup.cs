using System.Web.Mvc;
using Bs.Common;
using Bs.Enums;
using Bs.Models;

namespace Bs.Controls
{
    public static partial class BsExtensions
    {
        public static DisposableEnd ButtonGroup(this HtmlHelper helper)
        {
            return ButtonGroup(helper, new ButtonGroupModel());
        }

        public static DisposableEnd ButtonGroup(this HtmlHelper helper, ButtonGroupModel model)
        {
            var element = new ElementBuilder(ETag.Div, model)
                .AddHtmlAttributes(model.HtmlAttributes)
                .AddCssClasses(model.CssClasses)
                .Build();

            helper.ViewContext.Writer.Write(element.ToString(TagRenderMode.StartTag));

            return new DisposableEnd(helper, ETag.Div);
        }
    }
}

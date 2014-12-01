using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using Bs.Common;
using Bs.Enums;
using Bs.Models;

namespace Bs.Controls
{
    public static partial class BsExtensions
    {
        public static MvcHtmlString Button(this HtmlHelper helper, ButtonModel model)
        {
            var element = new ElementBuilder(ETag.Button, model)
                .AddHtmlAttributes(model.HtmlAttributes)
                .AddCssClasses(model.CssClasses)
                .Build();

            return new MvcHtmlString(element.ToString(TagRenderMode.Normal));
        }

        public static MvcHtmlString ButtonFor<TModel, TProperty>(this HtmlHelper<TModel> helper, Expression<Func<TModel, TProperty>> expression)
            where TProperty : ButtonModel
        {
            var metadata = ModelMetadata.FromLambdaExpression(expression, helper.ViewData);

            var model = metadata.Model as ButtonModel;

            return model == null ? new MvcHtmlString(string.Empty) : Button(helper, model);
        }

        public static DisposableEnd CustomButton(this HtmlHelper helper, ButtonModel model)
        {
            var element = new ElementBuilder(ETag.Button, model)
                .AddHtmlAttributes(model.HtmlAttributes)
                .AddCssClasses(model.CssClasses)
                .Build();

            helper.ViewContext.Writer.Write(element.ToString(TagRenderMode.StartTag));

            return new DisposableEnd(helper, ETag.Button);
        }
    }
}

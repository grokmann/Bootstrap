using System;
using System.Text;
using System.Web.Mvc;
using Bs.Enums;

namespace Bs
{
    public sealed class DisposableEnd : IDisposable
    {
        public DisposableEnd(HtmlHelper helper, EDisposableEndType disposableEndType, short count = 1)
        {
            Helper = helper;
            DisposableEndType = disposableEndType;
        }

        private HtmlHelper Helper { get; set; }

        private EDisposableEndType DisposableEndType { get; set; }

        private short Count { get; set; }

        public void Dispose()
        {
            var endTags = new StringBuilder();

            for (var i = 0; i < Count; i++)
            {
                endTags.Append(new TagBuilder(DisposableEndType.ToString().ToLower()).ToString(TagRenderMode.EndTag));
            }

            Helper.ViewContext.Writer.Write(endTags.ToString());
        }
    }
}

using System;
using System.Text;
using System.Web.Mvc;
using Bs.Enums;

namespace Bs.Common
{
    public sealed class DisposableEnd : IDisposable
    {
        public DisposableEnd(HtmlHelper helper, ETag tag, short count = 1)
        {
            Helper = helper;
            Tag = tag;
        }

        private HtmlHelper Helper { get; set; }

        private ETag Tag { get; set; }

        private short Count { get; set; }

        public void Dispose()
        {
            var endTags = new StringBuilder();

            for (var i = 0; i < Count; i++)
            {
                endTags.Append(new TagBuilder(Tag.ToString().ToLower()).ToString(TagRenderMode.EndTag));
            }

            Helper.ViewContext.Writer.Write(endTags.ToString());
        }
    }
}

using System.Collections.Generic;
using System.Web.Mvc;
using Bs.Enums;
using Bs.Interfaces;

namespace Bs.Common
{
    public class ElementBuilder
    {
        public ElementBuilder(ETag tag, IControlModel controlModel)
        {
            ControlModel = controlModel;
            Tag = tag;
        }

        public ElementBuilder AddHtmlAttributes(IDictionary<string, object> htmlAttributes)
        {
            HtmlAttributes = new Dictionary<string, object>(htmlAttributes);

            return this;
        }

        public ElementBuilder AddCssClasses(IEnumerable<string> cssClasses)
        {
            CssClasses = new List<string>(cssClasses);

            return this;
        }

        public TagBuilder Build()
        {
            TagBuilder = new TagBuilder(Tag.ToString().ToLower());

            ControlModel.Process();

            foreach (var htmlAttribute in HtmlAttributes)
            {
                TagBuilder.Attributes.Add(htmlAttribute.Key, htmlAttribute.Value.ToString());
            }

            foreach (var cssClass in CssClasses)
            {
                TagBuilder.AddCssClass(cssClass);
            }

            return TagBuilder;
        }

        private IControlModel ControlModel { get; set; }
        
        private TagBuilder TagBuilder { get; set; }

        private ETag Tag { get; set; }

        private IDictionary<string, object> HtmlAttributes { get; set; }

        private IList<string> CssClasses { get; set; }
    }
}

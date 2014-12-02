using System.Collections.Generic;
using Bs.Enums;

namespace Bs.Common
{
    public abstract class ModelBase
    {
        protected ModelBase()
        {
            HtmlAttributes = new Dictionary<string, object>();
            CssClasses = new List<string>();
            BootstrapColor = EBootstrapColor.Primary;
        }

        public IDictionary<string, object> HtmlAttributes { get; set; }

        public IList<string> CssClasses { get; set; }

        public EBootstrapColor BootstrapColor { get; set; }
    }
}

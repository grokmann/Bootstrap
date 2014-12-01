using System.Collections.Generic;

namespace Bs.Common
{
    public abstract class ModelBase
    {
        protected ModelBase()
        {
            HtmlAttributes = new Dictionary<string, object>();
            CssClasses = new List<string>();
        }

        public IDictionary<string, object> HtmlAttributes { get; set; }

        public IList<string> CssClasses { get; set; } 
    }
}

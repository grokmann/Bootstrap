using Bs.Common;
using Bs.Interfaces;

namespace Bs.Models
{
    public class ButtonGroupModel : ModelBase, IControlModel
    {
        public void Process()
        {
            CssClasses.Add("btn-group");
        }
    }
}
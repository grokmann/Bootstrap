using Bs.Common;
using Bs.Enums;
using Bs.Interfaces;

namespace Bs.Models
{
    public class ButtonModel : ModelBase, IControlModel
    {
        public ButtonModel()
        {
            ButtonType = EButtonType.Button;
        }

        public EButtonType ButtonType { get; set; }

        public void Process()
        {
            switch (ButtonType)
            {
                case EButtonType.Button:
                    HtmlAttributes.Add("type", "button");
                    break;
                case EButtonType.Submit:
                    HtmlAttributes.Add("type", "submit");
                    break;
            }
        }
    }
}

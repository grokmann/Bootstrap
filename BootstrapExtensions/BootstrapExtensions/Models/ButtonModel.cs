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

            CssClasses.Add("btn");

            switch (BootstrapColor)
            {
                case EBootstrapColor.Primary:
                    CssClasses.Add("btn-primary");
                    break;
                case EBootstrapColor.Success:
                    CssClasses.Add("btn-success");
                    break;
                case EBootstrapColor.Info:
                    CssClasses.Add("btn-info");
                    break;
                case EBootstrapColor.Warning:
                    CssClasses.Add("btn-warning");
                    break;
                case EBootstrapColor.Danger:
                    CssClasses.Add("btn-danger");
                    break;
            }
        }
    }
}

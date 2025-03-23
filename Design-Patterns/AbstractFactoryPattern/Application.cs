using Design_Patterns.AbstractFactoryPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.AbstractFactoryPattern
{
    public  class Application
    {
        private readonly IButton _button;
        private readonly ICheckbox _checkbox;
        public Application(IGUIFactory factory)
        {
            _button= factory.CreateButton();
            _checkbox= factory.CreateCheckbox();    

        }

        public void UIRender()
        {
            _button.Render();
            _checkbox.Render();
        }
    }
}

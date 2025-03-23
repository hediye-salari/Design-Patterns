using Design_Patterns.AbstractFactoryPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.AbstractFactoryPattern
{
    public class MacOSFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacOSButton();
        }

        public ICheckbox CreateCheckbox()
        {
           return new MacOSCheckbox();
        }
    }
}

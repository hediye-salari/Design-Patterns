using Design_Patterns.AbstractFactoryPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.AbstractFactoryPattern
{
    public class MacOSButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering a macOS Button.");
        }
    }
}

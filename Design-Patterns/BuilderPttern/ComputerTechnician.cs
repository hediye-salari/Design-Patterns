using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.BuilderPttern
{
    public class ComputerTechnician
    {
        private IComputerBuilder _builder;
        public ComputerTechnician(IComputerBuilder builder) => _builder=builder;
         public void BuildComputer()
        {
            _builder.SetCPU();
            _builder.SetRAM();
            _builder.SetStorage();
            _builder.SetGPU();
        }
        public Computer GetComputer() => _builder.GetComputer();
    }
       
}

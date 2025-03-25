using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.BuilderPttern
{
    public  interface IComputerBuilder // فقط مسئول ساخت است 
    {
        void SetCPU();
        void SetRAM();
        void SetStorage();
        void SetGPU();
        Computer GetComputer();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.BuilderPttern
{
    public class GamingComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();

        public void SetCPU() => _computer.CPU = "AMD Ryzen 9";
        public void SetRAM() => _computer.RAM = "32GB DDR5";
        public void SetStorage() => _computer.Storage = "1TB NVMe SSD";
        public void SetGPU() => _computer.GPU = "NVIDIA RTX 4090";
        public Computer GetComputer() => _computer;



    }
}

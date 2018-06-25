using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalComputer
{
    interface IComputerControl
    {
        void PushData(clsAllComputers prComputers);
        void UpdateControl(clsAllComputers prComputers);
    }
}

using CPUTempratureTest1.Machine.Movements;
using Dakota.Machine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUTempratureTest1.Machine
{
    public class ArduinoMachine : AbstractMachine
    {
        public ArduinoMachine(string Name) : base(new Guid().ToString(), Name)
        {
            NewMovement<BrightMovement>();
        }
    }
}

using Dakota.Machine;
using FpsCpuPanel;
using System;

namespace CPUTempratureTest1.Machine.Movements
{
    public class BrightMovement : AbstractMovement
    {
        public BrightMovement(IMachine Machine) : base(Machine, "Pot")
        {
            OnReceiveData += ReceiveData;
        }

        public void ReceiveData(IMachine Sender, object Data)
        {
            try
            {
                string PotValue = Data.ToString().Replace("\r","").Replace("Pot","");
                Console.WriteLine(PotValue);
                GammaLight.SetGamma(Convert.ToInt32(PotValue));
            }
            catch (Exception)
            { 
            }            
        }
    }
}

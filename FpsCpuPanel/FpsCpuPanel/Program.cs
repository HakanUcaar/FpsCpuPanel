using CPUTempratureTest1.Machine;
using Dakota.Receiver.SerialPort;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FpsCpuPanel
{
    class Program
    {
        public static SerialPortReceiver Receiver = new SerialPortReceiver(new ArduinoMachine("Arduino Cihazı"));
        static void Main(string[] args)
        {
            Receiver.DisConnect();
            Receiver.PortName = "COM3";
            Receiver.BaudRate = 9600;
            Receiver.Parity = Parity.None;
            Receiver.DataBits = 8;
            Receiver.StopBits = StopBits.One;
            Receiver.Handshake = Handshake.None;
            Receiver.Connect();

            FPSAndCPUTemperature Reader = new FPSAndCPUTemperature();
            Reader.Start();
            Console.ReadLine();
        }
    }
}

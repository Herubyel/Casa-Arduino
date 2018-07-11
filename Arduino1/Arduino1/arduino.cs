using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Arduino1
{
    class arduino
    {
        public string portName
        {
            get
            {
                return getPort();
            }
        }

        public int baudRate { get; }

        public arduino(int baudRate)
        {
            this.baudRate = baudRate;
        }

        public string getPort()
        {
            var ports = SerialPort.GetPortNames();
           
            if (ports.Length==1)
            {
                return ports[0];
                
            }
            else
            {
                return ports[1];
            }
        }

        public SerialPort GetSerialPort()
        {
            return new SerialPort()
            {
                PortName = this.portName,
                BaudRate = this.baudRate
            };
            
        }


    }
}

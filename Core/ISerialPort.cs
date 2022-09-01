using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace picpresencelib.Core
{
    internal interface ISerialPort
    {

        void Open();
        void Close();
        void Write(string data);
        void DataReceived(object sender, SerialDataReceivedEventArgs e);
    }
}

using System;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;

namespace picpresencelib.Core
{
    public class SerialPortFlow : ISerialPort
    {
        
        private string Port { get; set; }
        private int BaudRate;
        private int DataBits = 8;
        public SerialPort _serialPort;
        public delegate void Suscribe(string data);
        private int ReceivedBytesThreshold;
        private Suscribe _suscribe;
        public string Data;
        public string CurrentState { set; get; } 
        private enum State 
        {
            OPEN,
            BUSY,
            CLOSED
        }
        
        public SerialPortFlow(string Port, int BaudRate, int DataBits, int ReceivedBytesThreshold, Suscribe callBack)
        {
            this.Port = Port;
            this.BaudRate = BaudRate;
            this.DataBits = DataBits;
            this.ReceivedBytesThreshold = ReceivedBytesThreshold;
            _suscribe = callBack;
        }
        
        public void Open()
        {
      
            _serialPort = new SerialPort
            {
                PortName = Port,
                BaudRate = BaudRate,
                Parity = Parity.None,
                DataBits = DataBits,
                ReceivedBytesThreshold = ReceivedBytesThreshold,
                RtsEnable = true,
                DtrEnable = false
            };

            try
            {
                _serialPort.Open();
                _serialPort.DataReceived += DataReceived;
                CurrentState = State.OPEN.ToString();


            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                CurrentState = State.BUSY.ToString();
            }
        }
        public void Close()
        {
            if(_serialPort != null)
            {
                _serialPort.Close();
                CurrentState = State.CLOSED.ToString();
            }
            GC.Collect();
        }
        public void Write(string data)
        {
            if (_serialPort != null && _serialPort.IsOpen)
            {
                
                var formatedText = Formatter(data);

                formatedText = CheckWrapText(formatedText);

                _serialPort.Write(formatedText);
            
            }else
            {
                CurrentState = State.BUSY.ToString();
            }

            GC.Collect();
        }
        public void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            _suscribe.Invoke(_serialPort.ReadExisting());

            GC.Collect();
        }

        private string Formatter(string phrase)
        {
            return phrase
                .ToCharArray()
                .Select(w => " " + w)
                .Aggregate((x, y) => x + y);
        }

        private string CheckWrapText(string phrase)
        {
            if(phrase.Length > 31)
            {
                var spaces = new string(' ', 48);
                spaces = Formatter(spaces);

                var wrapPhrase = phrase[..32] + spaces + phrase[32..];

                return wrapPhrase;
            }

            return phrase;
        }
    }
}

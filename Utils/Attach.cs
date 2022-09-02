using picpresencelib.Core;
using System.Threading;

namespace picpresencelib.Utils
{
    public class Attach
    {
        public SerialPortFlow _serialPort { get; set; }
        public delegate string addRow();
        public delegate void callback();
        public int LCDVisibleAreaLength { get; set;}
        
        public Attach(SerialPortFlow _serialPort, int LCDVisibleAreaLength = 16)
        {
            this._serialPort = _serialPort;
            this.LCDVisibleAreaLength = LCDVisibleAreaLength;
        }

        public void Run(addRow r1, addRow r2, callback? callback = null, int delay = 1000)
        {

            Thread thr = new Thread(() =>
            {
                while (true)
                {

                    if(callback != null)
                    {
                        callback();
                    }
                        
                    var _r1 = r1();
                    var _r2 = r2();

                    if(_r1 != null && _r1.Length <= LCDVisibleAreaLength && 
                       _r2 != null && _r2.Length <= LCDVisibleAreaLength
                     )
                    {
                         _serialPort.Write(_r1+_r2);
                    }
 
                    Thread.Sleep(delay);
                }
            });
            thr.IsBackground = true;
            thr.Start();
        }
    }
}

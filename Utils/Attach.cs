﻿using picpresencelib.Core;
using System.Threading;

namespace picpresencelib.Utils
{
    public class Attach
    {
        public readonly SerialPortFlow _serialPort { get; set; }
        public delegate string addRow();

        public Attach(SerialPortFlow _serialPort)
        {
            this._serialPort = _serialPort;
        }

        public void Run(addRow r1, addRow r2, int delay)
        {

            Thread thr = new Thread(() =>
            {
                while (true)
                {
                    _serialPort.Write(
                        r1()+r2()
                    );

                    Thread.Sleep(delay);
                }
            });
            thr.IsBackground = true;
            thr.Start();
        }
    }
}

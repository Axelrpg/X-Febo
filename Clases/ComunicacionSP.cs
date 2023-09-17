using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_Febo.Clases
{
    public static class ComunicacionSP
    {
        private static SerialPort sp = new SerialPort();
        public static SerialPort SerialPort
        {
            get { return sp; }
            set { sp = value; }
        }
    }
}

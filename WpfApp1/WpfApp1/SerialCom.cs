using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;
using System.Windows.Threading;

namespace WpfApp1
{
    class SerialCom
    {
        public static SerialPort com { get; set; } = new SerialPort();
        //创建串口对象字段
        //添加static修饰主要是无需创建类的实例就能够访问的类中的字段和方法
        public static string com_name { get; set; }
        public static int com_Bound { get; set; }
        public static int com_DataBit { get; set; }
        public static string com_Verify { get; set; }
        public static string com_StopBit { get; set; }
        public static bool OpenState { get; set; }
        public static List<string> comdata = new List<string>();
    }
}

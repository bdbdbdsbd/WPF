using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Threading;

namespace WpfApp1
{
    class MyCom
    {
        //实现串口打开
        //对SerialCom的对象疯狂操作，把数据挪进来
        public void ComOpen()
        {
           
            if (SerialCom.OpenState == false)
            {
                SerialCom.com.PortName = SerialCom.com_name;
                SerialCom.com.BaudRate = SerialCom.com_Bound;
                SerialCom.com.DataBits = SerialCom.com_DataBit;
                if (SerialCom.com_StopBit ==  "1") { SerialCom.com.StopBits = System.IO.Ports.StopBits.One; }
                if (SerialCom.com_StopBit == "2") { SerialCom.com.StopBits = System.IO.Ports.StopBits.Two; }

                if(SerialCom.com_Verify == "None") { SerialCom.com.Parity = System.IO.Ports.Parity.None; }
                if (SerialCom.com_Verify == "Odd") { SerialCom.com.Parity = System.IO.Ports.Parity.Odd; }
                if (SerialCom.com_Verify == "Even") { SerialCom.com.Parity = System.IO.Ports.Parity.Even; }
                //回车换行
                SerialCom.com.NewLine = "\r\n";
                Comthread();
            }
            else
            {
                //close it 
                SerialCom.comdata.Add("close it");
                SerialCom.com.Close();
                SerialCom.OpenState = false;
            }
        }
        //读取数据
        //直接一个while写死
        public void WriteData(byte[] bytes)
        {
            if(SerialCom.OpenState && bytes != null)
            {
                SerialCom.com.Write(bytes, 0, bytes.Length);
            }
        }
        private void ReadDada()
        {
            SerialCom.comdata.Add("open is over");
            SerialCom.OpenState = true;
            while (SerialCom.OpenState)
            {
                
                //延时50ms
                Thread.Sleep(50);
                try
                {
                    int n = SerialCom.com.BytesToRead;
                    byte[] buf = new byte[n];
                    SerialCom.com.Read(buf, 0, n);
                    if (buf.Length > 0)
                    {
                        string str = Encoding.Default.GetString(buf);
                        SerialCom.comdata.Add(str);
                    }
                }
                catch
                {
                    SerialCom.OpenState = false;
                    SerialCom.com.Close();
                }
            }
        }
        //添加一个线程
        //这个还调用了一个线程给ReadDada
        private void Comthread()
        {
            SerialCom.com.Open();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            SerialCom.com.Encoding = Encoding.GetEncoding("utf-8");
            Thread thread = new Thread(ReadDada);
            thread.IsBackground = true;
            thread.Start();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO.Ports;
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    /// SerialCom这个类去存储这个
    public partial class MainWindow : Window
    {
        DispatcherTimer dtimer = new DispatcherTimer();
        private MyCom mCom = new MyCom();
        
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded (object sender, RoutedEventArgs e)
        {
            //这个定时器有啥用啊
            dtimer.Interval = TimeSpan.FromMilliseconds(100);//定时100ms
            dtimer.Tick += new EventHandler(timer_Tick);
            dtimer.Start();

            string[] portName = SerialPort.GetPortNames();
            this.Portname1.ItemsSource = portName;
            this.Portname1.SelectedIndex = 0;

            string[] borate = new string[]{"9600", "115200"};
            this.Portname2.ItemsSource = borate;
            this.Portname2.SelectedIndex = 0;

            this.Portname3.Items.Add(8);
            this.Portname3.Items.Add(7);
            this.Portname3.SelectedIndex = 0;

            this.Portname4.Items.Add(2);
            this.Portname4.Items.Add(1);
            this.Portname4.SelectedIndex = 0;

            this.Portname5.Items.Add("None");
            this.Portname5.Items.Add("Even");
            this.Portname5.Items.Add("Odd");
            this.Portname5.SelectedIndex = 0;

        }
        private void clickSearch(object sender, RoutedEventArgs e)
        {
            // SerialCom.com_name = portName.Text;
            //SerialCom.com.BaudRate = int.Parse(borate.Text);
            string[] ports = SerialPort.GetPortNames();
            this.Portname1.ItemsSource = ports;
            this.Portname1.SelectedIndex = 0;
        }
        private void clickOpen(object sender, RoutedEventArgs e)
        {
            SerialCom.com_name = Portname1.Text;
            SerialCom.com_Bound = int.Parse(Portname2.Text);
            SerialCom.com_DataBit = int.Parse(Portname3.Text);
            SerialCom.com_StopBit = Portname4.Text;
            SerialCom.com_Verify = Portname5.Text;
            show.Text = "open.";
            mCom.ComOpen();
        }

         private void clickSend(object sender, RoutedEventArgs e)
        {
            mCom.WriteData(Encoding.UTF8.GetBytes(sent.Text));
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            show.Text = string.Join(".", SerialCom.comdata.ToArray()); ;
        }

        }
    
}

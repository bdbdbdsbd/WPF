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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;

namespace UDP_TEST
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    
   

    public partial class MainWindow : Window
    {
        public SeriesCollection SeriesCollection { get; set; }
        private double _trend;
        //private double[] temp = { 1, 3, 2, 4, -3, 5, 2, 1 };
        int speedSend = 0;
        double speedRec = 0.0;
        double _trend2 = 0.0;
        public MainWindow()
        {
          
            InitializeComponent();
            //实例化一条折线图
            LineSeries mylineseries = new LineSeries();
            //设置折线的标题
            mylineseries.Title = "speed";
            //折线图直线形式
            mylineseries.LineSmoothness =1;
            //折线图的无点样式
            mylineseries.PointGeometry = null;
            //mylineseries.Values = new ChartValues<double>(temp);
            SeriesCollection = new SeriesCollection {     new LineSeries
                {
                    Title = "Series 1",
                    Values = new ChartValues<double> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
                },
                new LineSeries
                {
                    Title = "Series 2",
                    Values = new ChartValues<double> { 0,0,0,0,0,0,0,0,0,0,0 ,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 ,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 ,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                   
                }
            };
            //SeriesCollection.Add(mylineseries);
            _trend = 8;
            linestart();
            DataContext = this;

        }
        public void linestart()
        {
            Task.Run(() =>
            {
                var r = new Random();
                while (true)
                {
                    Thread.Sleep(200);
                    //_trend = r.Next(-10, 10);
                    _trend = i * 3.6;
                    _trend2 = speedRec;
                    //通过Dispatcher在工作线程中更新窗体的UI元素
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        //更新横坐标时间

                        //更新纵坐标数据
                        SeriesCollection[0].Values.Add(_trend);
                        SeriesCollection[0].Values.RemoveAt(0);
                        SeriesCollection[1].Values.Add(_trend2);
                        SeriesCollection[1].Values.RemoveAt(0);
                    });
                }
            });
        }

                          
        string ip = "172.93.177.47";
        Int32 sendport = 10002;
        Int32 recvport = 11112;
        string messageSend;
        int i = 1;
        //paint




        //fasong
        private void trans_Click(object sender, RoutedEventArgs e)
        {
            Task fasong = new Task(() =>
           {
               UdpClient sendClient = new UdpClient();
               try
               {
                   //Invoke(() =>{button.Text = "关闭";});
                   
                       Action action1 = () =>
                       {
                         
                           messageSend = sendBox.Text;
                           speedSend = int.Parse(sendBox.Text);
                           double speedSendKm = (speedSend/3.6);
                           listBox1.Dispatcher.Invoke(new Action(() => listBox1.Items.Add($"bd一号: {speedSend} KM/H")));
                           byte[] data = Encoding.UTF8.GetBytes(Convert.ToString(speedSendKm));
                           sendClient.Send(data, data.Length, ip, sendport);
                           sendBox.Text = "";
                       };
                       sendBox.Dispatcher.BeginInvoke(action1);
               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message);
               }
               finally
               {

               }
           });
            fasong.Start();
        }
        //lianjie




        private void link_Click(object sender, RoutedEventArgs e)
        {
            if (se.Text != null && re.Text != null && IP.Text != null)
            {
                sendport = int.Parse(se.Text);
                recvport = int.Parse(re.Text);
                ip =(IP.Text);
            }
            
            listBox1.Dispatcher.Invoke(new Action(() => listBox1.Items.Add($"initial...")));
            try
            { 
            //有些task是有wait的
            Task receivTask = new Task(() =>
                {
                    UdpClient receiver = new UdpClient(recvport);
                    IPEndPoint iPEndPoint = null;

                    try
                    {
                        while (true)
                        {
                            byte[] bytes = receiver.Receive(ref iPEndPoint);                            
                            string message = Encoding.UTF8.GetString(bytes);
                            string message2 = message;
                            speedRec = (double.Parse(message2))*3.6;
                            listBox1.Dispatcher.Invoke(new Action(() => listBox1.Items.Add($"bd二号: {(speedRec)}KM/H ")));
                            Thread.Sleep(200);  

                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        receiver.Close();
                    }
                }
                );
            receivTask.Start();
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Task fasong = new Task(() =>
            {
                UdpClient sendClient = new UdpClient();
                try
                {
                    //Invoke(() =>{button.Text = "关闭";});
                    while (true)
                    {
                        Action action1 = () =>
                        {

                            i = (i + 1) % 100;
                            listBox1.Dispatcher.Invoke(new Action(() => listBox1.Items.Add($"bd一号: {i * 3.6} KM/H")));
                            byte[] data = Encoding.UTF8.GetBytes(Convert.ToString(i));
                            sendClient.Send(data, data.Length, ip, sendport);
                            sendBox.Text = "";
                        };
                        sendBox.Dispatcher.BeginInvoke(action1);
                        Thread.Sleep(200);
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                }
            });
            fasong.Start();
        }
    }
}

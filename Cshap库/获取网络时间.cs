using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

public class 获取网络时间
{
    //方法2、获取ntp时间
    public static DateTime DataStandardTime()//使用时，将static 关键字删除，在其它位置方可使用?2010-11-24
    {//返回国际标准时间
     //只使用的TimerServer的IP地址，未使用域名
        string[,] TimerServer = new string[14, 2];
        int[] ServerTab = new int[] { 3, 2, 4, 8, 9, 6, 11, 5, 10, 0, 1, 7, 12 };
        TimerServer[0, 0] = "time-a.nist.gov";
        TimerServer[0, 1] = "129.6.15.28";
        TimerServer[1, 0] = "time-b.nist.gov";
        TimerServer[1, 1] = "129.6.15.29";
        TimerServer[2, 0] = "time-a.timefreq.bldrdoc.gov";
        TimerServer[2, 1] = "132.163.4.101";
        TimerServer[3, 0] = "time-b.timefreq.bldrdoc.gov";
        TimerServer[3, 1] = "132.163.4.102";
        TimerServer[4, 0] = "time-c.timefreq.bldrdoc.gov";
        TimerServer[4, 1] = "132.163.4.103";
        TimerServer[5, 0] = "utcnist.colorado.edu";
        TimerServer[5, 1] = "128.138.140.44";
        TimerServer[6, 0] = "time.nist.gov";
        TimerServer[6, 1] = "192.43.244.18";
        TimerServer[7, 0] = "time-nw.nist.gov";
        TimerServer[7, 1] = "131.107.1.10";
        TimerServer[8, 0] = "nist1.symmetricom.com";
        TimerServer[8, 1] = "69.25.96.13";
        TimerServer[9, 0] = "nist1-dc.glassey.com";
        TimerServer[9, 1] = "216.200.93.8";
        TimerServer[10, 0] = "nist1-ny.glassey.com";
        TimerServer[10, 1] = "208.184.49.9";
        TimerServer[11, 0] = "nist1-sj.glassey.com";
        TimerServer[11, 1] = "207.126.98.204";
        TimerServer[12, 0] = "nist1.aol-ca.truetime.com";
        TimerServer[12, 1] = "207.200.81.113";
        TimerServer[13, 0] = "nist1.aol-va.truetime.com";
        TimerServer[13, 1] = "64.236.96.53";
        int portNum = 13;
        string hostName;
        byte[] bytes = new byte[1024];
        int bytesRead = 0;
        System.Net.Sockets.TcpClient client = new System.Net.Sockets.TcpClient();
        for (int i = 0; i < 13; i++)
        {
            hostName = TimerServer[ServerTab[i], 0];
            // Debug.WriteLine("hostName:" + hostName);
            try
            {
                client.Connect(hostName, portNum);
                System.Net.Sockets.NetworkStream ns = client.GetStream();
                bytesRead = ns.Read(bytes, 0, bytes.Length);
                client.Close();
                break;
            }
            catch (Exception)
            {
                Debug.WriteLine("错误！");
            }
        }
        char[] sp = new char[1];
        sp[0] = ' ';
        DateTime dt = new DateTime();
        string str1 = Encoding.ASCII.GetString(bytes, 0, bytesRead);

        if (!(str1 == string.Empty))
        {
            //Debug.WriteLine("ntp time:" + str1);
            string[] s = str1.Split(sp);
            try
            {
                dt = DateTime.Parse(s[1] + " " + s[2]);
            }
            catch (Exception)
            {
                MessageBox.Show(str1);
                return DateTime.Parse("2099-1-1");
            }
            //得到标准时间
            //Debug.WriteLine("get:" + dt.ToShortTimeString());
            dt = dt.AddHours(8);//得到北京时间*/
            return dt;
        }
        else
        {
            MessageBox.Show("请检查网络");
            return DateTime.Parse("2099-1-1");
        }
    }
}

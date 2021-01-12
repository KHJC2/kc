using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foxtable;
namespace Cshap控制台
{
    class Program
    {
        static void Main()
        {
            //Computer computer = Computer.Instance();
            //Console.WriteLine(computer.ComputerName);
            //Console.WriteLine(computer.CpuID);
            //Console.WriteLine(computer.DiskID);
            //Console.WriteLine(computer.IpAddress);
            //Console.WriteLine(computer.LoginUserName);
            //Console.WriteLine(computer.MacAddress);
            //Console.WriteLine(computer.SystemType);
            //Console.WriteLine(computer.TotalPhysicalMemory);
            //foreach (string ss in ssss.GetBoard()) 
            //{
            //    Console.WriteLine(ss);
            //}
            //foreach (string ss in ssss.GetCPUID())
            //{
            //    Console.WriteLine(ss);
            //}
            //foreach (string ss in ssss.GetHardDiskInfo())
            //{
            //    Console.WriteLine(ss);
            //}
            //foreach (string ss in ssss.GetMacAddress())
            //{
            //    Console.WriteLine(ss);
            //}
            for (int i = 0; i < 3; i++)
            {
                DateTime dateTime = 获取网络时间.DataStandardTime();
                DateTime dateTime1 = DateTime.Now;
                Console.WriteLine(dateTime.ToString("yyyy-MM-dd HH:mm:ss:fffffff"));
                Console.WriteLine(dateTime1.ToString("yyyy-MM-dd HH:mm:ss:fffffff"));
                TimeSpan timeSpan = dateTime - dateTime1;
                Console.WriteLine(timeSpan.TotalMilliseconds);
                Console.WriteLine("_____________________");

            }


            Console.ReadLine();




        }
    }

}

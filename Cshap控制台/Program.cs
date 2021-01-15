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
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine(全局ID.GenerateUniqueID());

            //}
            //Console.WriteLine("----------------------------");

            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine(全局ID.GenerateOrderNumber());

            //}
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine(Guid.NewGuid());

            //}



            for (int i = 0; i < 100; i++)
            {
                DateTime dateTime = DateTime.MaxValue;
                //DateTime dateTime1 = new DateTime(2021, 1, 12, 23, 59, 59, 999);
                DateTime dt2020 = new DateTime(9999, 12, 31, 23, 59, 59, 999);

                DateTime dateTime1 = DateTime.Now;
                TimeSpan span = dateTime1 - dt2020;
                long  de = span.Ticks;
                 Console.WriteLine(de.ToString("0000000000000000000.00000"));

                //Console.WriteLine(span.TotalMilliseconds.ToString("0.00"));
            }
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine(Guid.NewGuid().GetHashCode());
            //}
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine(全局ID.GenerateUnique);
            //}
            Guid guid = Guid.NewGuid();
            byte[] b = guid.ToByteArray();
            string str = guid.ToString();

            Guid guid1 = new Guid(b);
            Guid guid2 = new Guid(str);
            //long l = Convert.ToInt64(b);
        //string     lll = BitConverter.ToString(b, 0, b.Length);
            //long ll = BitConverter.ToInt64(b, 0);
            //byte[] b1 = BitConverter.GetBytes(ll);
            //Guid guid12 = new Guid(b1);

            Console.WriteLine(guid.ToString());
            Console.WriteLine(guid1.ToString());
            Console.WriteLine(guid2.ToString());

            //Console.WriteLine(guid12.ToString());
            //Console.WriteLine(l);
            //Console.WriteLine(ll);
            //Console.WriteLine(lll);

            //Console.WriteLine(Guid.NewGuid());
            Console.ReadLine();
            



        }
    }

}

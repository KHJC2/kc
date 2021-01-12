using System.Collections.Generic;
using System.Management;

public class ssss
{

    /// <summary>
    /// 获取CPU的编号
    /// </summary>
    /// <returns>CPU的编号</returns>
    public static List<string> GetCPUID()
    {
        List<string> lstInfo = new List<string>();
        ManagementClass cimobject = new ManagementClass("Win32_Processor");
        ManagementObjectCollection moc = cimobject.GetInstances();
        foreach (ManagementObject mo in moc)
        {
            string cpuInfo = mo.Properties["ProcessorId"].Value.ToString();//cpu序列号
            lstInfo.Add(cpuInfo);
        }
        return lstInfo;
    }

    /// <summary>
    /// 获取硬件信息
    /// </summary>
    /// <returns>硬件信息集合</returns>
    public static List<string> GetHardDiskInfo()
    {
        List<string> lstInfo = new List<string>();
        ManagementClass cimobject1 = new ManagementClass("Win32_DiskDrive");
        ManagementObjectCollection moc1 = cimobject1.GetInstances();
        foreach (ManagementObject mo in moc1)
        {
            string HDid = (string)mo.Properties["Model"].Value;
            lstInfo.Add(HDid);
        }
        return lstInfo;
    }

    /// <summary>
    /// 获取Mac地址
    /// </summary>
    /// <returns>Mac地址集合</returns>
    public static List<string> GetMacAddress()
    {
        List<string> lstInfo = new List<string>();
        ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
        ManagementObjectCollection moc = mc.GetInstances();
        foreach (ManagementObject mo in moc)
        {
            if ((bool)mo["IPEnabled"] == true)
            {
                lstInfo.Add(mo["MacAddress"].ToString());
            }
            mo.Dispose();
        }
        return lstInfo;
    }


    /// <summary>
    /// 获取主板信息
    /// </summary>
    /// <returns>主板信息集合</returns>
    public static List<string> GetBoard()
    {
        List<string> lstInfo = new List<string>();

        ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_baseboard");
        foreach (ManagementObject mo in mos.Get())
        {
            lstInfo.Add(mo["SerialNumber"].ToString());
            break;
        }
        return lstInfo;
    }
}

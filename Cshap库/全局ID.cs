using System;

public class 全局ID
{
    //利用时间和Guid作为种子产生随机数
    public  static string GenerateUniqueID()
    {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        string str1 = DateTime.Now.ToString("yyyyMMddHHmmss");
        Random d = new Random(Guid.NewGuid().GetHashCode());
        string str2 = d.Next(10000, 100000).ToString();
        return sb.Append(str1).Append(str2).ToString();
    }

    public static long GenerateUnique
    {
        get
        {
            byte[] buffer = Guid.NewGuid().ToByteArray();
            return BitConverter.ToInt64(buffer, 0);
        }
    }



    //利用时间和RNGCryptoServiceProvider产生
    public static string GenerateOrderNumber()
    {
        string strDateTimeNumber = DateTime.Now.ToString("yyyyMMddHHmmssms");
        string strRandomResult = NextRandom(1000, 1).ToString();
        return strDateTimeNumber + strRandomResult;
    }

    /// <summary>
    /// 参考：msdn上的RNGCryptoServiceProvider例子
    /// </summary>
    /// <param name="numSeeds"></param>
    /// <param name="length"></param>
    /// <returns></returns>
    private static int NextRandom(int numSeeds, int length)
    {
        // Create a byte array to hold the random value.  
        byte[] randomNumber = new byte[length];
        // Create a new instance of the RNGCryptoServiceProvider.  
        System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
        // Fill the array with a random value.  
        rng.GetBytes(randomNumber);
        // Convert the byte to an uint value to make the modulus operation easier.  
        uint randomResult = 0x0;
        for (int i = 0; i < length; i++)
        {
            randomResult |= ((uint)randomNumber[i] << ((length - 1 - i) * 8));
        }
        return (int)(randomResult % numSeeds) + 1;
    }
}
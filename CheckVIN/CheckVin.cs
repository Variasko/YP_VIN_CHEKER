using System.Security.Cryptography.X509Certificates;

namespace CheckVIN
{
    public class CheckVIN
    {
        public Boolean CheckVin(string a)
        {
            string all_letter = "0123456789ABCDEFGHJKLMNPRSTUVWXYZ";
            int b = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (all_letter.Contains(a[i]))
                    {
                    b += 1;
                    }
            }
            if (b == a.Length)
            {
                return true;
            }
            else
            { return false;}
            
        }
    }
}
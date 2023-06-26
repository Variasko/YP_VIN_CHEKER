using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckVIN
{
    public class CountryGet
    {
        public string CountryGets(string a) 
        { 
            string index = a.Substring(0, 1);

            string index2 = a.Substring(1, 2);

            string resault;


            Dictionary<string, string> countryy = new Dictionary<string, string>();

            countryy.Add("1", "USA");
            countryy.Add("4", "USA");
            countryy.Add("5", "USA");
            countryy.Add("2", "Canada");
            countryy.Add("3", "Mexica");
            countryy.Add("9", "Brazilia");
            countryy.Add("J", "Japan");
            countryy.Add("K", "Koreya");
            countryy.Add("Y", "Schwecia");
            countryy.Add("S", "Angliya");
            countryy.Add("V", "Ispania");
            countryy.Add("W", "Germany");
            countryy.Add("Z", "Italy");

            resault = countryy[index];
            return resault; 
            


        }
    }
}

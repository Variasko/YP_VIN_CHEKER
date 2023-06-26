using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckVIN
{
    public class YearGet
    {
        public int Yearget(string a)
        {
            int resault;

            string index = a.Substring(9, 1);

            Dictionary<string, int> year = new Dictionary<string, int>();

            year.Add("A", 1980);
            year.Add("B", 1981);
            year.Add("C", 1982);
            year.Add("D", 1983);
            year.Add("E", 1984);
            year.Add("F", 1985);
            year.Add("G", 1986);
            year.Add("H", 1987);
            year.Add("J", 1988);
            year.Add("K", 1989);
            year.Add("L", 1990);
            year.Add("M", 1991);
            year.Add("N", 1992);
            year.Add("P", 1993);
            year.Add("R", 1994);
            year.Add("S", 1995);
            year.Add("T", 1996);
            year.Add("V", 1997);
            year.Add("W", 1998);
            year.Add("X", 1999);
            year.Add("Y", 2000);
            year.Add("1", 2001);
            year.Add("2", 2002);
            year.Add("3", 2003);
            year.Add("4", 2004);
            year.Add("5", 2005);
            year.Add("6", 2006);
            year.Add("7", 2007);
            year.Add("8", 2008);
            year.Add("9", 2009);


            resault = year[index];


            return resault;
        }
    }
}

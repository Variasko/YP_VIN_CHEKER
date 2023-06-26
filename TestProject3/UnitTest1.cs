using CheckVIN;

namespace TestProject3
{
    public class UnitTest1
    {
        [Fact]
        public void TestOnTrue()
        {
            string a = "1GNSKCKC8FR218986";

            var vin = new CheckVIN.CheckVIN();

            Boolean actual = vin.CheckVin(a);

            Assert.True(actual);


        }
        [Fact]
        public void TestOnFalse()
        {
            string a = "1GNSKCKC8FR**218986";

            var vin = new CheckVIN.CheckVIN();

            Boolean actual = vin.CheckVin(a);

            Assert.False(actual);

            
        }

         [Fact]
        public void Japan_Test()
        {
            string a = "JAMAE620500101234";

            string etalon = "Japan";

            var uar = new CountryGet();

            String actual = uar.CountryGets(a);

            Assert.Equal(actual, etalon);
            

            
        }   
        [Fact]
        public void USA_Test()
        {
            string a = "1AMAE620500101234";

            string etalon = "USA";

            var uar = new CountryGet();

            String actual = uar.CountryGets(a);

            Assert.Equal(actual, etalon);
            

            
        }
       [Fact]
        public void Asia_Test()
        {
            string a = "8AMAE620500101234";

            string etalon = "Asia";

            var uar = new CountryGet();

            String actual = uar.CountryGets(a);

            Assert.Equal(actual, etalon);
            

            
        }
       [Fact]
        public void Canada_Test()
        {
            string a = "8AMAE620500101234";

            string etalon = "Canada";

            var uar = new CountryGet();

            String actual = uar.CountryGets(a);

            Assert.Equal(actual, etalon);
            

            
        }
        [Fact]
        public void Correct_Canada_Test()
        {
            string a = "2AMAE620500101234";

            string etalon = "Canada";

            var uar = new CountryGet();

            String actual = uar.CountryGets(a);

            Assert.Equal(actual, etalon);
            

            
        }
        [Fact]
        public void Year_Check_1988()
        {
            string a = "2AMAE6205J0101234";

            int etalon = 1988;

            var uar = new YearGet();

            int actual = uar.Yearget(a);

            Assert.Equal(actual, etalon);
            

            
        }
        [Fact]
        public void Year_Check_2031()
        {
            string a = "2AMAE620510101234";

            int etalon = 2031;

            var uar = new YearGet();

            int actual = uar.Yearget(a);

            Assert.Equal(actual, etalon);
            

            
        }
        [Fact]
        public void Year_Check_1975()
        {
            string a = "2AMAE620550101234";

            int etalon = 1975;

            var uar = new YearGet();

            int actual = uar.Yearget(a);

            Assert.Equal(actual, etalon);
            

            
        }
        [Fact]
        public void Year_Check_2009()
        {
            string a = "2AMAE620590101234";

            int etalon = 2009;

            var uar = new YearGet();

            int actual = uar.Yearget(a);

            Assert.Equal(actual, etalon);
            

            
        }
        [Fact]
        public void Year_Check_1994()
        {
            string a = "2AMAE6205R0101234";

            int etalon = 1994;

            var uar = new YearGet();

            int actual = uar.Yearget(a);

            Assert.Equal(actual, etalon);
            

            
        }
        

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Address
    {
        public string roadNo;
        public string houseNo;
        public string city;
        public string country;

        public void SetRoadNo(string R)
        {
            this.roadNo = R;
        }

        public void SetHouseNO(string H)
        {
            this.houseNo = H;
        }
        public void SetCity(string C)
        {
            this.city = C;
        }
        public void SetCountry(string Cn)
        {
            this.country = Cn;
        }
        public string GetRoadNo()
        {
            return this.roadNo;
        }
        public string GetHouseNo()
        {
            return this.houseNo;
        }
        public string GetCity()
        {
            return this.city;

        }
        public string GetCountry()
        {
            return this.country;
        }
        public void display()
        {
            System.Console.WriteLine("Road No: " + this.GetRoadNo());
            System.Console.WriteLine("House No: " + this.GetHouseNo());
            System.Console.WriteLine("Country : " + this.GetCountry());
            System.Console.WriteLine("City : " + this.GetCity());

        }

    }
}
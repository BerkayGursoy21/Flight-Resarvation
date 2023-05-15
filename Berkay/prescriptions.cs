using Berkay.mains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Berkay
{
    internal class prescriptions
    {
        public string Customer;
        public string Airplane;
        public string Location;
        public string Date;
        public string bK;

        public prescriptions(string Ad, string Soyad,string airplane,string location,string date,string bk)
        {

            Customer = Ad + " " + Soyad;
            Airplane = airplane;
            Location = location;    
            Date = date;
            bK = bk;

        }
        public string UcusDondur()
        {
            //uçuş bilgileri

            Reservation rezervasyon = new Reservation();
            
            string Temp = "\n NEREDEN: " + bK + "\n NEREYE: " + Location + "\n Uçuş Tarihiniz: " + Date +  "\n ADINIZ SOYADINIZ: " + Customer + "\n Uçağınız: " + Airplane +  "\n Koltuk Numaranız: " + rezervasyon.PassangerNumber + "\n Bilet Tutarınız: " + rezervasyon.Price + "TL";            
            return Temp;

        }
    }

}

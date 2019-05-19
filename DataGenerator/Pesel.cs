using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGenerator
{
    public class Pesel
    {

        private void PESEL()
        {
            Random random = new Random();

            string generatedYear = "", generatedMonth = "", generatedDay = "";

            int year = random.Next(1, 100);
            if (year < 10)
            {
                generatedYear += year.ToString().PadLeft(2, '0');
            }
            else
            {
                generatedYear += year.ToString();
            }



            int month = random.Next(1, 13);
            if (month < 10)
            {
                generatedMonth += month.ToString().PadLeft(2, '0');
            }
            else
            {
                generatedMonth += month.ToString();
            }


            int day = random.Next(1, 32);
            if (day < 10)
            {
                generatedDay += day.ToString().PadLeft(2, '0');
            }
            else
            {
                generatedDay += day.ToString();
            }


            int gender = random.Next(1111, 10000);

        }
       
   }
}

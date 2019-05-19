using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace DataGenerator
{
    public partial class DataGenerator : Form
    {
        public DataGenerator()
        {
            InitializeComponent();
        }


        private void btnNIP_Click(object sender, EventArgs e)
        {

            Random random = new Random();

            string generatedYear = "", generatedMonth = "", generatedDay = "";

            int year = random.Next(1, 100);
            if (year < 10)
            {
                generatedYear += year.ToString().PadLeft(2, '0');
            }
            else {
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

            string preWeightNum = generatedYear + generatedMonth + generatedDay + gender;

            int[] array = new int[10] { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };

            List<string> preWeightNumList = preWeightNum.Select(c => c.ToString()).ToList();
    


            tbNIP.Text = preWeightNum;
            
        }

        private void DataGenerator_Load(object sender, EventArgs e)
        {

        }
    }
}

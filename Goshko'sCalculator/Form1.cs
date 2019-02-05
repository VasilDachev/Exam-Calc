using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goshko_sCalculator
{
    public partial class Form1 : Form
    {
        List<int> numbers = new List<int>();
        public int startNumber;
        public int endNumber;
        public int generatedNumber;
        public int Min;
        public int Max;
        public double Average;
        public int Sum;
        public int Common;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSetStart_Click(object sender, EventArgs e)
        {
            string enteredNumber = tbEnter.Text;
            
            if (tbEnter.Text != "")
            {
                startNumber = int.Parse(enteredNumber);
                numbers.Add(startNumber);
                lbNumbers.Items.Add(startNumber);
                tbEnter.Text = " ";

            }
            else
            {
                MessageBox.Show("Въведи нещо преди това!");
            }
            


        }

        private void btnSetEnd_Click(object sender, EventArgs e)
        {
            string endingNumber = tbEnd.Text;
            if (tbEnd.Text != "")
            {
                endNumber = int.Parse(endingNumber);
                numbers.Add(endNumber);
                lbNumbers.Items.Add(endNumber);
                tbEnd.Text = "";
            }
            else
            {
                MessageBox.Show("Въведи нещо преди това!");
            }
        }

        private void btnInterval_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            lbNumbers.Items.Clear();
            if (startNumber != 0 || endNumber != 0)
            {
                for (int i = 0; i < 20; i++)
                {
                    int number = rnd.Next(startNumber, endNumber);
                    lbNumbers.Items.Add(number);
                    numbers.Add(number);
                }
            }
            else
            {
                MessageBox.Show("Въведи граници преди това!");
            }
           
            
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                 Min = numbers.Min();
                lblMin.Text = Min.ToString();
                 Max = numbers.Max();
                lblMax.Text = Max.ToString();
                 Average = numbers.Average();
                lblAverage.Text = Average.ToString();
                 Sum = numbers.Sum();
                lblSum.Text = Sum.ToString();

            }
            catch (InvalidOperationException)
            {

                MessageBox.Show("Няма какво да пресмяташ!");
            }
         


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lbNumbers.Items.Clear();
            numbers.Clear();
            startNumber = 0;
            endNumber = 0;
            
            lblAverage.Text = "";
            lblCommon.Text = "";
            lblMax.Text = "";
            lblMin.Text = "";
            lblSum.Text = "";
         

        }
    }
}

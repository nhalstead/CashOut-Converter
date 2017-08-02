using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cash_Out___Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Money_Dollar.Focus();
        }

        private void CalculatorBTN_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {

            int Coins;
            int Dollars;

            if (Money_Dollar.Text == String.Empty)
            {
                Dollars = 0;
                Money_Dollar.Text = "0";
            }
            else { Dollars = Convert.ToInt32(Money_Dollar.Text); }

            if (Money_Cent.Text == String.Empty)
            {
                Coins = 0;
                Money_Cent.Text = "00";
            }
            else { Coins = Convert.ToInt32(Money_Cent.Text); }

            int Quarters = 0;
            int Dimes = 0;
            int Nickels = 0;
            int Pennys = 0;

            Quarters = Coins / 25;
            Coins = Coins - (Quarters * 25);
            Dimes = Coins / 10;
            Coins = Coins - (Dimes * 10);
            Nickels = Coins / 5;
            Coins = Coins - (Nickels * 5);
            Pennys = Coins;

            Money_Quarter.Text = Convert.ToString(Quarters);
            Money_Dime.Text = Convert.ToString(Dimes);
            Money_Nickel.Text = Convert.ToString(Nickels);
            Money_Penny.Text = Convert.ToString(Pennys);

            // -----------------------------------------------------------------

            int OneHun = 0;
            int Fiftey = 0;
            int Twenty = 0;
            int Ten = 0;
            int Five = 0;
            int One = 0;

            OneHun = Dollars / 100;
            Dollars = Dollars - (OneHun * 100);
            Fiftey = Dollars / 50;
            Dollars = Dollars - (Fiftey * 50);
            Twenty = Dollars / 20;
            Dollars = Dollars - (Twenty * 20);
            Ten = Dollars / 10;
            Dollars = Dollars - (Ten * 10);
            Five = Dollars / 5;
            Dollars = Dollars - (Five * 5);
            One = Dollars;

            Dollar_100.Text = Convert.ToString(OneHun);
            Dollar_50.Text = Convert.ToString(Fiftey);
            Dollar_20.Text = Convert.ToString(Twenty);
            Dollar_10.Text = Convert.ToString(Ten);
            Dollar_5.Text = Convert.ToString(Five);
            Dollar_1.Text = Convert.ToString(One);

        }
        
        private void ResetBTN_Click(object sender, EventArgs e)
        {
            Money_Dollar.Text = "0";
            Money_Cent.Text = "00";

            Dollar_100.Text = "0";
            Dollar_50.Text = "0";
            Dollar_20.Text = "0";
            Dollar_10.Text = "0";
            Dollar_5.Text = "0";
            Dollar_1.Text = "0";

            Money_Quarter.Text = "0";
            Money_Dime.Text = "0";
            Money_Nickel.Text = "0";
            Money_Penny.Text = "0";
        }

        private void Money_Dollar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Decimal || e.KeyChar == (char)ConsoleKey.OemPeriod || e.KeyChar == (char)ConsoleKey.Spacebar)
            {
                Money_Cent.Focus();
            }

            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                Calculate();
            }

        }

        private void Money_Cent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Backspace && Money_Cent.Text == String.Empty)
            {
                Money_Dollar.Focus();
            }

            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                Calculate();
            }

        }

    }
}

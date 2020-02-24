using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const double sushiCost = 6.50;
        const double udonCost = 4.00;
        const double bubbleTeaCost = 2.50;
        const double tempuraCost = 4.00;
        const double hst = 0.13;
        double totalSushi;
        double totalUdon;
        double totalBT;
        double totalTempura;
        double subTotal;
        double tax;
        double totalCost;
        double change;
        int tenderedAmount;
        int sushi;
        int udon;
        int bubbleTea;
        int tempura;

        private void SushiText_TextChanged(object sender, EventArgs e)
        { //finds the sushi cost
            try
            {
               
                sushi = Convert.ToInt16(sushiText.Text);
                totalSushi = sushi * sushiCost;
            }
            catch
            {
                costOutputLabel.Text = "You must enter a number";
                return; 
            }
            
        }

        private void UdonText_TextChanged(object sender, EventArgs e)
        { // finds the udon cost 
            try
            {
                
                udon = Convert.ToInt16(udonText.Text);
                totalUdon = udon * udonCost;
            }
            catch
            {
                costOutputLabel.Text = "You must enter a number";
                return;
            }
            
        }

        private void BubbleTeaText_TextChanged(object sender, EventArgs e)
        { //finds the bubble tea cost 
            try
            {
              
                bubbleTea = Convert.ToInt16(bubbleTeaText.Text);
                totalBT = bubbleTea * bubbleTeaCost; 
            }
            catch
            {
                costOutputLabel.Text = "You must enter a number";
                return;
            }
            
        }

        private void TempuraText_TextChanged(object sender, EventArgs e)
        { // finds the tempura cost 
            try
            {
               
                tempura = Convert.ToInt16(tempuraText.Text);
                totalTempura = tempura * tempuraCost; 
            }
            catch
            {
                costOutputLabel.Text = "You must enter a number";
                return;
            }
           
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        { // calculates the cost of your order, the tax, and the total cost 
          // prints it to the screen 
            subTotal = totalTempura + totalBT + totalUdon + totalSushi;
            tax = subTotal * hst;
            totalCost = tax + subTotal;
           

            costOutputLabel.Text = "Sub Total: " + subTotal.ToString("C");
            costOutputLabel.Text += "\nTax: " + tax.ToString("C");
            costOutputLabel.Text += "\nTotal: " + totalCost.ToString("C");

        }

        private void TenderedInput_TextChanged(object sender, EventArgs e)
        { //takes the amount of money payed and calculates the change
          //prints the change to the screen 
            try
            {
                tenderedAmount = Convert.ToInt16(tenderedInput.Text);
                change = tenderedAmount - totalCost;
                

            }
            catch
            {
                changeLabel.Text = "You must enter a number";
                return;
            }

            
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            changeLabel.Text = "Change: " + change.ToString("C");
        }

        private void ReceiptButton_Click(object sender, EventArgs e)
        {
            SoundPlayer receiptPrint = new SoundPlayer(Properties.Resources.Printer);
            receiptPrint.Play();

            receiptLabel.Text = "Hao's Sushi";

            Refresh();
            Thread.Sleep(200);

            receiptPrint.Play();

            receiptLabel.Text += "\nSushi x" + sushi + " @ " + sushiCost.ToString("C");

            Refresh();
            Thread.Sleep(200);

            receiptPrint.Play();

            receiptLabel.Text += "\nUdon Bowl(s) x" + udon + " @ " + udonCost.ToString("C");

            Refresh();
            Thread.Sleep(200);

            receiptPrint.Play();

            receiptLabel.Text += "\nBubble Tea x" + bubbleTea + " @ " + bubbleTeaCost.ToString("C");

            Refresh();
            Thread.Sleep(200);

            receiptPrint.Play();

            receiptLabel.Text += "\nMixed Tempura x" + tempura + " @ " + tempuraCost.ToString("C");

            Refresh();
            Thread.Sleep(200);

            receiptPrint.Play();

            receiptLabel.Text += "\nSub Total: " + subTotal.ToString("C");

            Refresh();
            Thread.Sleep(300);

            receiptPrint.Play();

            receiptLabel.Text += "\nTax: " + tax.ToString("C");

            Refresh();
            Thread.Sleep(200);

            receiptPrint.Play();

            receiptLabel.Text += "\nTotal: " + totalCost.ToString("C");

            Refresh();
            Thread.Sleep(200);

            receiptPrint.Play();

            receiptLabel.Text += "\nTendered Amount: " + tenderedAmount.ToString("C");

            Refresh();
            Thread.Sleep(200);

            receiptPrint.Play();

            receiptLabel.Text += "\nChange: " + change.ToString ("C");

            Refresh();
            Thread.Sleep(200);

            receiptPrint.Play();

            receiptLabel.Text += "\n" + "\nHave a nice day!! :)";
        }

        private void NewOrder_Click(object sender, EventArgs e)
        {
            receiptLabel.Text = String.Empty;
            changeLabel.Text = String.Empty;
            costOutputLabel.Text = String.Empty;
            tenderedInput.Text = String.Empty;
            sushiText.Text = String.Empty;
            udonText.Text = String.Empty;
            bubbleTeaText.Text = String.Empty;
            tempuraText.Text = String.Empty;



        }
    }
}

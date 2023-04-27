using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zgadywanka
{
    public partial class Form1 : Form
    {
        int liczbaDoOdgadniecia;
        int liczbaProb = 0;
        public Form1()
        {
            InitializeComponent();

            // tworzymy generator
            Random random = new Random();

            // losujemy liczbę 
            liczbaDoOdgadniecia = random.Next(1, 1001);

            // wpisujemy informację o liczbie prób 
            textBox2.Text = liczbaProb.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // przechwytywanie liczby od usera
            int podanaLiczba = int.Parse(textBox1.Text);

            //  zwiększamy liczbę prób o jeden
            liczbaProb++;

            // odświeżamy liczbę prób w textBox
            textBox2.Text = liczbaProb.ToString();

            if(podanaLiczba > liczbaDoOdgadniecia)
            {
                MessageBox.Show("Podana liczba jest za duża");
            }
            else if(podanaLiczba < liczbaDoOdgadniecia)
            {
                MessageBox.Show("Podana liczba jest za mała");
            }
            else if(podanaLiczba == liczbaDoOdgadniecia)
            {
                MessageBox.Show($"Gratulacje zgadłeś za {liczbaProb} razem!!!");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Podana liczba jest nieprawidłowa");
            }
        }
    }
}

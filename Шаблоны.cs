using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Shablony : Form
    {
      //  int Kategoria 

        public Shablony()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Bryki bryki = new Bryki("Платья");
            bryki.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Bryki bryki = new Bryki("Брюки");
            bryki.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bryki bryki = new Bryki("Юбки");
            bryki.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bryki bryki = new Bryki("Пиджаки");
            bryki.ShowDialog();
        }

        private void Shablony_Load(object sender, EventArgs e)
        {
            Text = "Шаблоны";
        }

        private void Vodolazki_Click(object sender, EventArgs e)
        {
            Bryki bryki = new Bryki("Водолазки");
            bryki.ShowDialog();

        }

      /*   if (Kategoria = F1)
                
            else if (OB< 116)
                kolich = kolich + 2 * DI + 30;
            else
                kolich = kolich + 3 * DI + 30;

            MessageBox.Show("Надо " + kolich.ToString());


    */


    }
}

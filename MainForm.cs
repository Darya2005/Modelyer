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
    public partial class MainForm : Form
    {
        //public static Image SelectedImage;
        string formula;

        public MainForm(PictureBox pb, string category)
        {
            InitializeComponent();
            pictureBox1.Image = pb.Image;
            Text = Text + " " + pb.Tag + " " + pb.Text;
            formula = pb.Text;
            resultButton_Click(null, null);
        }

        /// <summary>
        /// Количество ткани
        /// </summary>
        int kolich = 0;

        
        /// <summary>
        /// Юбка плиссе
        /// </summary>
        void raschetYubki()
        {
            int OB = Convert.ToInt32(OBTextBox.Value);
            int OG = Convert.ToInt32(OGTextBox.Value);
            int DI = Convert.ToInt32(DITextBox.Value);
            int DR = Convert.ToInt32(DRTextBox.Value);
            int OT = Convert.ToInt32(OTTextBox.Value);


            if (OB < 104)
                kolich = kolich + DI + 30;
            else if (OB < 116)
                kolich = kolich + 2 * DI + 30;
            else
                kolich = kolich + 3 * DI + 30;

        }

        /// <summary>
        /// Юбка обычная
        /// </summary>
        void raschetYubki2()
        {
            int OB = Convert.ToInt32(OBTextBox.Value);
            int OG = Convert.ToInt32(OGTextBox.Value);
            int DI = Convert.ToInt32(DITextBox.Value);
            int DR = Convert.ToInt32(DRTextBox.Value);
            int OT = Convert.ToInt32(OTTextBox.Value);


            if (OB < 104)
                kolich = kolich + DI + 30;
            else if (OB < 116)
                kolich = kolich + DI + 30;
            else
                kolich = kolich + 2 * DI + 30;

        }
        /// <summary>
        /// Юбка в складку
        /// </summary>
        void raschetYubki3()
        {
            int OB = Convert.ToInt32(OBTextBox.Value);
            int OG = Convert.ToInt32(OGTextBox.Value);
            int DI = Convert.ToInt32(DITextBox.Value);
            int DR = Convert.ToInt32(DRTextBox.Value);
            int OT = Convert.ToInt32(OTTextBox.Value);


            if (OB < 104)
                kolich = kolich + 2 * DI + 50;
            else if (OB < 116)
                kolich = kolich + 2 * DI + 70;
            else
                kolich = kolich + 2 * DI + 90;

        }
        /// <summary>
        /// Брюки/леггинсы
        /// </summary>
        void raschetBruk()
        {
            int OB = Convert.ToInt32(OBTextBox.Value);
            int OG = Convert.ToInt32(OGTextBox.Value);
            int DI = Convert.ToInt32(DITextBox.Value);
            int DR = Convert.ToInt32(DRTextBox.Value);
            int OT = Convert.ToInt32(OTTextBox.Value);


            if (OB < 104)
                kolich = kolich + DI + 30;
            else if (OB < 116)
                kolich = kolich + 3 * DI / 2 + 30;
            else
                kolich = kolich + 2 * DI + 30;

        }
        /// <summary>
        /// Брюки с поясом
        /// </summary>
        void raschetBruk2()
        {
            int OB = Convert.ToInt32(OBTextBox.Value);
            int OG = Convert.ToInt32(OGTextBox.Value);
            int DI = Convert.ToInt32(DITextBox.Value);
            int DR = Convert.ToInt32(DRTextBox.Value);
            int OT = Convert.ToInt32(OTTextBox.Value);


            if (OB < 104)
                kolich = kolich + DI + 50;
            else if (OB < 116)
                kolich = kolich + 3 * DI / 2 + 30;
            else
                kolich = kolich + 2 * DI + 30;

        }
        /// <summary>
        /// платье Летучая мышь
        /// </summary>
        void raschetPlatya()
        {
            int OB = Convert.ToInt32(OBTextBox.Value);
            int OG = Convert.ToInt32(OGTextBox.Value);
            int DI = Convert.ToInt32(DITextBox.Value);
            int DR = Convert.ToInt32(DRTextBox.Value);
            int OT = Convert.ToInt32(OTTextBox.Value);


            if (OB < 104)
                kolich = kolich + 3 * DI / 2 + 30; 
            else if (OB < 116)
                kolich = kolich + 2 * DI + 30;
            else
                kolich = kolich + 2 * DI + 30;

        }



        private void resultButton_Click(object sender, EventArgs e)
        {
            if (formula == "Юбки1")
            {
                kolich = 0;
                raschetYubki();
            }
            else if (formula == "Юбки2")
            {
                kolich = 0;
                raschetYubki2();
            }
            else if (formula == "Юбки3")
            { 
                kolich = 0;
                raschetYubki3();
            }
            else if (formula == "Юбки4")
            {
                kolich = 150;
            }
            else if (formula == "Брюки1")
            {
                kolich = 0;
                raschetBruk();
            }
            else if (formula == "Брюки2")
            {
                kolich = 0;
                raschetBruk();
            }


            textBox1.Text = kolich.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Shablony form3 = new Shablony();
            form3.Show();
          //  pictureBox1.Image = MainForm.SelectedImage;
           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

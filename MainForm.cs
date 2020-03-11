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

        /// <summary>
        /// Количество ткани
        /// </summary>
        int kolich = 0;

        /// <summary>
        /// Обхват бедер
        /// </summary>
        int OB;
        /// <summary>
        /// Обхват груди
        /// </summary>
        int OG;
        int DI;
        int DR;
        int OT;

        Odezda od;

        private void PBizb_Click(object sender, EventArgs e)
        {
            Избранное.izbrannoe.Add(od);
        }

        public MainForm(Odezda od1)
        {
            od = od1;
            InitializeComponent();
            pictureBox1.Image = od.pb.Image;
            Text = Text + " " + od.name;
            formula = od.category + od.formula;
            resultButton_Click(null, null);

            if (od.category == "Юбки")
            {
                OGlabel.Visible = false;
                OGTextBox.Visible = false;
            }
        }


        
        /// <summary>
        /// Юбка плиссе
        /// </summary>
        void raschetYubki()
        {
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
            if (OB < 104)
                kolich = kolich + 3 * DI / 2 + 30; 
            else if (OB < 116)
                kolich = kolich + 2 * DI + 30;
            else
                kolich = kolich + 2 * DI + 30;
        }

        void raschetPlatya2()
        {
            if (OB < 104)
                kolich = kolich + 2 * DI + 30;
            else if (OB < 116)
                kolich = kolich + 2 * DI + 100;
            else
                kolich = kolich + 2 * DI + 150;
        }

        void raschetPlatya3()
        {
            if (OB < 104)
                kolich = kolich +  DI + DR +30;
            else if (OB < 116)
                kolich = kolich + DI + DR + 30;
            else
                kolich = kolich + 2 * DI + DR + 30;

        }

        void raschetPidgaka1()
        {
            if (OB < 104)
                kolich = kolich + DI + DR + 70;
            else if (OB < 116)
                kolich = kolich + 2 * DI + DR;
            else
                kolich = kolich + 2 * DI + DR + 30;

        }



        private void resultButton_Click(object sender, EventArgs e)
        {
            OB = Convert.ToInt32(OBTextBox.Value);
            OG = Convert.ToInt32(OGTextBox.Value);
            DI = Convert.ToInt32(DITextBox.Value);
            DR = Convert.ToInt32(DRTextBox.Value);
            OT = Convert.ToInt32(OTTextBox.Value);

            kolich = 0;

            if (DI <= 0)
            {
                MessageBox.Show("Укажите длину изделия!");
                
                 return;
            }

            if      (formula == "Юбки1")                raschetYubki();
            else if (formula == "Юбки2")                raschetYubki2();
            else if (formula == "Юбки3")                raschetYubki3();
            else if (formula == "Юбки4")                kolich = 150;
            else if (formula == "Брюки1")               raschetBruk();
            else if (formula == "Брюки2")               raschetBruk2();
            else if (formula == "Платья1")              raschetPlatya();
            else if (formula == "Платья2")              raschetPlatya2();
            else if (formula == "Платья3")              raschetPlatya3();
            else if (formula == "Пиджаки1")              raschetPidgaka1();

            textBox1.Text = kolich.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Izb_Click_1(object sender, EventArgs e)
        {
            Избранное избранное = new Избранное();
            избранное.Show();
        }
    }
}

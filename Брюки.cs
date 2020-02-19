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
    public struct Odezda
    {
        public string name;
        public string category;
        public string formula;
        public PictureBox pb;

        public Odezda(string _name, string _category, string _formula)
        {
            name = _name;
            category = _category;
            formula = _formula;
            pb = new PictureBox();
        }
    }

    public partial class Bryki : Form
    {
        Odezda[] odezda = new Odezda[100];

        public Bryki(string category)
        {
            InitializeComponent();
            Text = category;


            odezda[0] = new Odezda("Готическая", "Юбки", "1");
            odezda[1] = new Odezda("Юбки", "Юбки", "2");
            odezda[2] = new Odezda("Jielur", "Юбки", "3");
            odezda[3] = new Odezda("Юбки2", "Юбки", "");
            odezda[4] = new Odezda("bruki", "Брюки", "");
            odezda[5] = new Odezda("брюки", "Брюки", "");
            odezda[6] = new Odezda("VONDA", "Брюки", "");
            odezda[7] = new Odezda("брюки2", "Брюки", "");

            int x = 10;
            int y = 200;
            for (int i = 0; i < 8; i++)
            {
                odezda[i].pb.Location = new Point(x, y);
                odezda[i].pb.Size = new Size(200, 200);
                odezda[i].pb.SizeMode = PictureBoxSizeMode.Zoom;
                odezda[i].pb.Click += new EventHandler(PictureBox1_Click);
                odezda[i].pb.Load("../../Pictures/" + odezda[i].category + "/" + odezda[i].name + ".jpg");
                Controls.Add(odezda[i].pb);
                x = x + 200;

                if (x > Width - 200)
                {
                    x = 10;
                    y = y + 220;
                }
            }

            /*if (Text == "Брюки")
            {
                pictureBox1.Load("../../Pictures/Брюки/bruki.jpg");
                pictureBox1.Tag = "1";
                pictureBox2.Load("../../Pictures/Брюки/брюки.jpg");
                pictureBox3.Load("../../Pictures/Брюки/VONDA.jpg");
                pictureBox4.Load("../../Pictures/Брюки/брюки2.jpg");
            }

            if (Text == "Юбки")
            {
                pictureBox1.Load("../../Pictures/Юбки/Готическая.jpg");
                pictureBox2.Load("../../Pictures/Юбки/Юбки.jpg");
                pictureBox3.Load("../../Pictures/Юбки/Jielur.jpg");
                pictureBox4.Load("../../Pictures/Юбки/Юбки2.jpg");
            }

            if (Text == "Платья")
            {
                pictureBox1.Load("../../Pictures/Платья/Платье1.jpg");
                pictureBox2.Load("../../Pictures/Платья/Платье2.jpg");
                pictureBox3.Load("../../Pictures/Платья/Платье3.jpeg");
                pictureBox4.Image = null;
            }

            if (Text == "Пиджаки")
            {
                pictureBox1.Load("../../Pictures/Пиджаки/Пиджак1.jpg");
                pictureBox2.Load("../../Pictures/Пиджаки/Пиджак2.jpg");
                pictureBox3.Image = null;
                pictureBox4.Image = null;
            }*/
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb1 = (PictureBox)sender;
            MainForm form3 = new MainForm(pb1, Text);
            form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("У тебя денег нет!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MainForm form3 = new MainForm(pictureBox2, Text);
            form3.Show();
        }


        private void PictureBox4_Click(object sender, EventArgs e)
        {
            MainForm form3 = new MainForm(pictureBox4, Text);
            form3.Show();
        }

        private void PictureBox3_Click_1(object sender, EventArgs e)
        {
            MainForm form3 = new MainForm(pictureBox3, Text);
            form3.Show();
        }

        private void Bryki_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int x = 10;
            int y = 200;
            for (int i = 0; i < 8; i++)
            {
                odezda[i].pb.Visible = true;

                if (comboBox1.Text != "" &&
                    odezda[i].category != comboBox1.Text)
                {
                    odezda[i].pb.Visible = false;
                }


                if (odezda[i].pb.Visible)
                {
                    odezda[i].pb.Location = new Point(x, y);
                    x = x + 200;

                    if (x > Width - 200)
                    {
                        x = 10;
                        y = y + 220;
                    }
                }
            }
        }
    }
}

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
            odezda[1] = new Odezda("Юбки", "Юбки", "3");
            odezda[2] = new Odezda("Jielur", "Юбки", "2");
            odezda[3] = new Odezda("Юбки2", "Юбки", "4");
            odezda[4] = new Odezda("bruki", "Брюки", "2");
            odezda[5] = new Odezda("брюки", "Брюки", "1");
            odezda[6] = new Odezda("VONDA", "Брюки", "1");
            odezda[7] = new Odezda("брюки2", "Брюки", "1");
            odezda[8] = new Odezda("Платье1", "Платья", "1");
            odezda[9] = new Odezda("Платье2", "Платья", "");
            odezda[10] = new Odezda("Платье3", "Платья", "");

            int x = 10;
            int y = 100;
            for (int i = 0; i < 11; i++)
            {
                odezda[i].pb.Location = new Point(x, y);
                odezda[i].pb.Text = odezda[i].category + odezda[i].formula;
                odezda[i].pb.Size = new Size(100, 100);
                odezda[i].pb.SizeMode = PictureBoxSizeMode.Zoom;
                odezda[i].pb.Click += new EventHandler(PictureBox1_Click);
                odezda[i].pb.Load("../../Pictures/" + odezda[i].category + "/" + odezda[i].name + ".jpg");
                Controls.Add(odezda[i].pb);
                x = x + 100;

                if (x > Width - 100)
                {
                    x = 10;
                    y = y + 120;
                }
            }

            comboBox1.Text = category;

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

        /// <summary>
        /// Поиск
        /// </summary>
        private void poisk(object sender, EventArgs e)
        {
            int x = 10;
            int y = 100;
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
                    x = x + 100;

                    if (x > Width - 100)
                    {
                        x = 10;
                        y = y + 120;
                    }
                }
            }
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Text = "1";

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Text = "2";

        }

        private void Bryki_Load(object sender, EventArgs e)
        {

        }
    }
}

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
        public int minSize;
        public int maxSize;
        public PictureBox pb;
        public Label lb;

        public Odezda(string _name, string _category, string _formula, int _minSize, int _maxSize)
        {
            name = _name;
            minSize = _minSize;
            maxSize = _maxSize;
            category = _category;
            formula = _formula;
            pb = new PictureBox();
            lb = new Label();
        }
    }

    public partial class Bryki : Form
    {
        public static Odezda[] odezda = new Odezda[13];

        public Bryki(string category)
        {
            InitializeComponent();
            Text = category;



            odezda[0] = new Odezda("Готическая", "Юбки", "1", 50,70);
            odezda[1] = new Odezda("Юбки", "Юбки", "3", 46,80);
            odezda[2] = new Odezda("Jielur", "Юбки", "2", 46, 80);
            odezda[3] = new Odezda("Юбки2", "Юбки", "4", 46, 80);
            odezda[4] = new Odezda("bruki", "Брюки", "2", 46, 80);
            odezda[5] = new Odezda("брюки", "Брюки", "1", 4,80);
            odezda[6] = new Odezda("VONDA", "Брюки", "1", 46, 80);
            odezda[7] = new Odezda("брюки2", "Брюки", "1", 42, 80);
            odezda[8] = new Odezda("Платье1", "Платья", "1", 46, 80);
            odezda[9] = new Odezda("Платье2", "Платья", "3", 46,80);
            odezda[10] = new Odezda("Платье3", "Платья", "2", 12, 80);
            odezda[11] = new Odezda("Пиджак1", "Пиджаки", "1", 46, 80);
            odezda[12] = new Odezda("Пиджак2", "Пиджаки", "1", 46,80);


            int x = 10;
            int y = 100;
            for (int i = 0; i < odezda.Length; i++)
            {
                odezda[i].pb.Location = new Point(x, y);
                odezda[i].pb.Text = odezda[i].category + odezda[i].formula;
                odezda[i].pb.Size = new Size(150, 150);
                odezda[i].pb.SizeMode = PictureBoxSizeMode.Zoom;
                odezda[i].pb.Click += new EventHandler(PictureBox1_Click);
                odezda[i].pb.Load("../../Pictures/" + odezda[i].category + "/" + odezda[i].name + ".jpg");
                Controls.Add(odezda[i].pb);



                odezda[i].lb.Location = new Point(x, y + 150);
                odezda[i].lb.Size = new Size(155, 13);
                odezda[i].lb.Text = "Размер: " + odezda[i].minSize.ToString() + "-"+ odezda[i].maxSize.ToString();
                Controls.Add(odezda[i].lb);





                x = x + 160;

                if (x > Width - 150)
                {
                    x = 10;
                    y = y + 200;
                }
            }

            comboBox1.Text = category;
        }

        public static void PictureBox1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 11; i++)
            {
                if (((PictureBox)sender).Image == odezda[i].pb.Image)
                {
                    MainForm form3 = new MainForm(odezda[i]);
                    form3.Show();
                }
            }
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
            for (int i = 0; i < odezda.Length; i++)
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
                    odezda[i].lb.Location = new Point(x, y + 150);
                    x = x + 160;

                    if (x > Width - 150)
                    {
                        x = 10;
                        y = y + 200;
                    }
                }
            }
        }

        

        private void Bryki_Load(object sender, EventArgs e)
        {

        }
    }
}

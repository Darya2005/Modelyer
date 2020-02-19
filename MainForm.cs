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

        public MainForm(PictureBox pb, string category)
        {
            InitializeComponent();
            pictureBox1.Image = pb.Image;
            Text = Text + " " + pb.Tag;
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }


        int kolich = 0;

        

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



        private void resultButton_Click(object sender, EventArgs e)
        {
            kolich = 0;
            raschetYubki();
            textBox1.Text = kolich.ToString();

            kolich = 0;
            raschetYubki2();
            textBox2.Text = kolich.ToString();

            kolich = 0;
            raschetYubki3();
            textBox3.Text = kolich.ToString();

            //MessageBox.Show("Надо " + kolich.ToString());
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
    }
}

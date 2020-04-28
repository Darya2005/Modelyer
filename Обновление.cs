using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Обновление : Form
    {
        public Обновление()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.File.AppendAllText("Одежда.txt", "Пиджак2;Пиджаки;2;ткань;12;80;Шелк,3000,Трикотаж,7000,Фатин,5000;10" + Environment.NewLine);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void OGlabel_Click(object sender, EventArgs e)
        {

        }

        private void OGlabel_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Обновление_Load(object sender, EventArgs e)
        {

        }
          
        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.File.AppendAllText("Одежда.txt",
                Environment.NewLine +
                NameTB.Text + ";"+ CategoryCB.Text + ";2;ткань;12;80;Шелк,3000,Трикотаж,7000,Фатин,5000;5");
             System.IO.File.Copy(FileName, "../../Pictures/" + CategoryCB.Text + "/" + NameTB.Text + ".jpg");
        }
        // textBox1.Text + "," + textBox2.Text + "," + textBox3.Text
    

         string FileName;
        private void button3_Click(object sender, EventArgs e)
        {
             int i = 0;
            string variants = "";

            if (NameTB.Text != "" && Int32.TryParse(CategoryCB.Text, out i))
                variants += ", " + NameTB.Text + ", " + CategoryCB.Text;
            if (NomberTB.Text != "" && Int32.TryParse(MateriaTB.Text, out i))
                variants += ", " + NomberTB.Text + ", " + MateriaTB.Text;
            if (MinSizeTB.Text != "" && Int32.TryParse(MaxSizeTB.Text, out i))
                variants += ", " + MinSizeTB.Text + ", " + MaxSizeTB.Text;
            if (Variant1TB.Text != "" && Int32.TryParse(Price1TB.Text, out i))
                variants += ", " + Variant1TB.Text + ", " + Price1TB.Text;
            if (Variant2TB.Text != "" && Int32.TryParse(Price2TB.Text, out i))
                variants += ", " + Variant2TB.Text + ", " + Price2TB.Text;
            if (Variant3TB.Text != "" && Int32.TryParse(Price3TB.Text, out i))
                variants += ", " + Variant3TB.Text + ", " + Price3TB.Text;




            if (variants.Length > 0)
                variants = variants.Substring(2, variants.Length - 4);

            System.IO.File.AppendAllText("Одежда.txt",
                Environment.NewLine +
                NameTB.Text + ";" + CategoryCB.Text + ";2;ткань;12;80;" + variants + ";" + TimeTB.Text);



        }
    }
}

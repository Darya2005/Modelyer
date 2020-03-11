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
    public partial class Избранное : Form
    {
        Odezda[] odezda = new Odezda[13];
        public static List<Odezda> izbrannoe = new List<Odezda>();

        public Избранное()
        {
            InitializeComponent();
            foreach (Odezda od in Избранное.izbrannoe)
            {
                PictureBox pb = new PictureBox();
                pb.Image = od.pb.Image;
                pb.Location = od.pb.Location;
                pb.Text = od.pb.Text;
                pb.Size = od.pb.Size;
                pb.SizeMode = od.pb.SizeMode;
                pb.Click += new EventHandler(Bryki.PictureBox1_Click);

                Label lb = new Label();
                lb.Location = od.lb.Location;
                lb.Size = od.lb.Size;
                lb.Text = od.lb.Text;


                /*odezda[i].pb.Location = new Point(x, y);
                odezda[i].pb.Text = odezda[i].category + odezda[i].formula;
                odezda[i].pb.Size = new Size(150, 150);
                odezda[i].pb.SizeMode = PictureBoxSizeMode.Zoom;
                odezda[i].lb.Location = new Point(x, y + 150);
                odezda[i].lb.Size = new Size(155, 13);
                odezda[i].lb.Text = "Раз*/

                Controls.Add(pb);
                Controls.Add(lb);
            }
        }

        private void Избранное_Load(object sender, EventArgs e)
        {

        }
    }
}

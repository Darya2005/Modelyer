using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using System.Net;
using System.Net.Mail;



namespace WindowsFormsApp4
{
    public partial class Избранное : Form
    {
        Odezda[] odezda = new Odezda[13];
        public static List<Odezda> izbrannoe = new List<Odezda>();

        public Избранное()
        {
            InitializeComponent();

            int x = 30;
            int y = 60;
            foreach (Odezda od in Избранное.izbrannoe)
            {
                //Картинка слева
                PictureBox pb = new PictureBox();
                pb.Image = od.pb.Image;
                pb.Location = new Point(x, y);
                pb.Text = od.pb.Text;
                pb.Size = new Size(100, 100);
                pb.SizeMode = od.pb.SizeMode;
                pb.Click += new EventHandler(Bryki.PictureBox1_Click);

                //заголовок, размер и материал во 2 столбце
                Label lb2 = new Label();
                lb2.Location = new Point(x + 180, y);
                lb2.TextAlign = ContentAlignment.MiddleCenter;
                lb2.Font = new Font("Arial", 20);
                lb2.Size = new Size(250, 40);
                lb2.Text = od.name;

                Label lb = new Label();
                lb.Location = new Point(x + 150, y + 40);
                lb.Font = new Font("Arial", 14);
                lb.Size = new Size(250, 30);
                lb.Text = od.lb.Text;

                Label lb3 = new Label();
                lb3.Location = new Point(x + 150, y + 70);
                lb3.Font = new Font("Arial", 12);
                lb3.Size = new Size(90, 30);
                lb3.Text = "Материал: ";

                ComboBox cb = new ComboBox();
                cb.Location = new Point(x + 250, y + 70);
                cb.Size = new Size(150, 30);
                cb.Font = new Font("Arial", 14);
                cb.Items.Clear();
                foreach (string variant in od.Tseny.Keys)
                {
                    cb.Items.Add(variant);
                }
                cb.Text = od.material;
                cb.Tag = od.name;
                cb.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);

                //Цена в 3 столбце
                Label lb4 = new Label();
                lb4.Location = new Point(x + 450, y + 70);
                lb4.Font = new Font("Arial", 12);
                lb4.Size = new Size(100, 30);
                lb4.Text = "Цена ~ 1500";// + od.Tsena;


                Label lb5 = new Label();
                lb5.Location = new Point(x + 450, y + 40);
                lb5.Font = new Font("Arial", 12);
                lb5.Size = new Size(150, 30);
                lb5.Text = "Время ~" + od.Vremya + " часов";



                Controls.Add(pb);
                Controls.Add(lb);
                Controls.Add(lb2);
                Controls.Add(lb3);
                Controls.Add(lb4);
                Controls.Add(lb5);
                Controls.Add(cb);
                y = y + 111;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;
            {
                ComboBox cb = (ComboBox)sender;
                foreach (Odezda usl in Избранное.izbrannoe)
                {
                    if (cb.Location == new Point(30 + 250, +130 + 111 * i))
                    {
                        foreach (Control ctrl in Controls)
                        {
                            if (ctrl is Label &&
                                 ctrl.Location == new Point(30 + 450, +130 + 111 * i))
                            {
                                ctrl.Text = "Цена ¬" + usl.Tseny[cb.Text].ToString();
                            }
                        }

                    }

                    i = i + 1;
                }
            }
        }

        private void Избранное_Load(object sender, EventArgs e)
        {

        }



        private void ZakazB_Click(object sender, EventArgs e)

        {

            MailAddress fromMailAddress = new MailAddress("ilchencodarya@gmail.com", "Заказчик");
            MailAddress toAddress = new MailAddress("ilchencodarya@gmail.com");

            using (MailMessage mailMessage = new MailMessage(fromMailAddress, toAddress))
            using (SmtpClient smtpClient = new SmtpClient())

            {

                mailMessage.Subject = "Новый заказ!";

                mailMessage.IsBodyHtml = true;
                mailMessage.Body = System.IO.File.ReadAllText("Шаблон.txt");

                    System.IO.File.WriteAllText("Заказ.csv",
                        "Новый заказ!,," +
                 Environment.NewLine + "Список:");
                 foreach (Odezda od in Избранное.izbrannoe)
                 {
                    System.IO.File.AppendAllText("Заказ.csv",
                     Environment.NewLine +
                   od.name + ";" + od.category );
                   
                 }
                mailMessage.Attachments.Add(new Attachment("Заказ.csv"));
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, "Здесь должен быть пароль от эл.почты");





                smtpClient.Send(mailMessage);


            }
        }
    }
}


    








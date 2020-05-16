using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApp4
{
    public partial class Техническая_поддержка : Form
    {
        public Техническая_поддержка()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MailAddress fromMailAddress = new MailAddress(textBox3.Text);
            MailAddress toAddress = new MailAddress("ilchencodarya@gmail.com");

            MailMessage mailMessage = new MailMessage(fromMailAddress, toAddress);
            SmtpClient smtpClient = new SmtpClient();

            mailMessage.Subject = "Новый отзыв";
            mailMessage.Body =
                "Раздел: " + comboBox1.Text + Environment.NewLine +
                "Как связаться: " + textBox2.Text + Environment.NewLine +
                Environment.NewLine +
                "Сообщение:" + Environment.NewLine + textBox1.Text;

            if (address1 != "")
                mailMessage.Attachments.Add(new Attachment(address1));
            if (address2 != "")
                mailMessage.Attachments.Add(new Attachment(address2));

            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, textBox4.Text);

            MessageBox.Show("Спасибо за отзыв");
        }

        string address1 = "";
        string address2 = "";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

    

   

      
    




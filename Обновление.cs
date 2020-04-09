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
    }
}

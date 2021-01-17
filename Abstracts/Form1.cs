using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstracts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRecArea_Click(object sender, EventArgs e)
        {
            Rectangle r = new Rectangle();
            r.Short = Convert.ToDecimal(textBox1.Text);
            r.Long = Convert.ToDecimal(textBox2.Text);
            MessageBox.Show($"The area of the rectangular is :{r.Area()}");
            textBox1.Clear();
            textBox2.Clear();
        }

        private void btnSquareArea_Click(object sender, EventArgs e)
        {
            Square s = new Square();
            s.Edge = Convert.ToDecimal(textBox3.Text);
            MessageBox.Show($"The area of the square is :{s.Area()}");
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Triangle t = new Triangle();
            t.Height = Convert.ToDecimal(textBox4.Text);
            t.Floor = Convert.ToDecimal(textBox5.Text);
            MessageBox.Show($"The area of the Triangle is {t.Area()}");
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = (this.Width - pictureBox1.Width) / 2;
            int y = this.Height / 2 - pictureBox1.Height;

            Point p = new Point(x, y);
            pictureBox1.Location = p;

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Random move = new Random();

            int x = move.Next(this.Width - pictureBox1.Width - 20);
            int y = move.Next(this.Height - pictureBox1.Height - 20);

            Point p = new Point(x, y);
            pictureBox1.Location = p;
        }
    }
}

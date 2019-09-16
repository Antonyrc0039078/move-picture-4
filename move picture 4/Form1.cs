using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace move_picture_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            {
                if (pictureBox1.Location.Y + 0 < ClientRectangle.Width - pictureBox1.Width)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.Y - 25, pictureBox1.Location.Y);
                }
            }
        }

        private void Down_Click(object sender, EventArgs e)
        {
            {
                if (pictureBox1.Location.Y + 0 < ClientRectangle.Width - pictureBox1.Width)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.Y + 25, pictureBox1.Location.Y);
                }
            }
        }

        private void Right_Click(object sender, EventArgs e)
        {
            {
                if (pictureBox1.Location.X + 25 < ClientRectangle.Width - pictureBox1.Width)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X + 25, pictureBox1.Location.Y);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingAppWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Draw();
        }
        
        private void Draw()
        {
            
            Bitmap btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            btm.SetPixel( 50, 50, Color.DarkViolet);
            pictureBox1.Image = btm;

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
           int x = e.X;
           int y = e.Y;

           


        }
    }
}

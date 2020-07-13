using GraphicRedactor000.Tool;
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

namespace GraphicRedactor000
{
    public partial class Form1 : Form
    {
        public bool cursorAktive;
        ITool tool;
        public Form1()
        {
            InitializeComponent();
           // tool = new Tool.Brush();
            StaticBitMap.Bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }
        
        private void Draw()
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (tool != null)
            {
                tool.MouseDown((PictureBox)sender, e);
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (tool != null)
            {
                tool.MouseUp((PictureBox)sender, e);
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (tool != null)
            {
                tool.MouseMove((PictureBox)sender, e);
            }
        }


        

        private void buttonChangeColor_MouseClick(object sender, MouseEventArgs e)
        {
            ColorDialog cdl = new ColorDialog();
            if (cdl.ShowDialog()==DialogResult.OK)
            {
                
                pictureBox1.BackColor = cdl.Color;
            }
        }

        private void buttonDrawLine_Click(object sender, EventArgs e)
        {

        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
           
            tool = new Tool.BrushTool();
        }
    }
}

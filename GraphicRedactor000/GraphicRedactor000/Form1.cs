﻿using System;
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
        public Form1()
        {
            InitializeComponent();
            Draw();
            StaticBitMap.Bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }
        
        private void Draw()
        {
            
            

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
           int x = e.X;
           int y = e.Y;

            StaticBitMap.Bitmap.SetPixel(e.X, e.Y, Color.DarkViolet);
            pictureBox1.Image = StaticBitMap.Bitmap;
        }

        

        private void buttonChangeColor_MouseClick(object sender, MouseEventArgs e)
        {
            ColorDialog cdl = new ColorDialog();
            if (cdl.ShowDialog()==DialogResult.OK)
            {
                
                pictureBox1.BackColor = cdl.Color;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using GraphicRedactor000.Draw;

namespace GraphicRedactor000.Tool
{
    class Brush : ITool
    {
        bool cursorActive { get; set; }
        int x1, y1, x2, y2;
        public void MouseDown(PictureBox drawArea, MouseEventArgs e)
        {
            cursorActive = true;
            x1 = e.X;
            y1 = e.Y;
            Drawer drawer = new Drawer(x1, y1, x1, y1);

            StaticBitMap.Bitmap.SetPixel(e.X, e.Y, Color.DarkViolet);
            drawArea.Image = StaticBitMap.Bitmap;
        }

        public void MouseUp(PictureBox drawArea, MouseEventArgs e)
        {
            cursorActive = false;
            x2 = e.X;
            y2 = e.Y;

            StaticBitMap.Bitmap.SetPixel(e.X, e.Y, Color.DarkViolet);
            drawArea.Image = StaticBitMap.Bitmap;
        }

        public void MouseMove(PictureBox drawArea, MouseEventArgs e)
        {
            if (cursorActive)
            {
                x2 = e.X;
                y2 = e.Y;
               // Drawer drawer = new Drawer(x1, y1, x2, y2);

                StaticBitMap.Bitmap.SetPixel(e.X, e.Y, Color.DarkViolet);
                drawArea.Image = StaticBitMap.Bitmap;
            }
        }
    }
}

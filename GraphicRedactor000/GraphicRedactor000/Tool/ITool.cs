using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GraphicRedactor000.Tool
{
   public interface ITool
    {
        void MouseDown(PictureBox drawArea, MouseEventArgs e);
        void MouseUp(PictureBox drawArea, MouseEventArgs e);
        void MouseMove(PictureBox drawArea, MouseEventArgs e);
    }
}

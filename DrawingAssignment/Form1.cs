using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLAB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool shouldDraw;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            shouldDraw = true;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(shouldDraw)
            {
                Graphics g = base.CreateGraphics();
                SolidBrush s1 = new SolidBrush(Color.PeachPuff);
                g.FillEllipse(s1, e.X, e.Y, 10, 10);
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            shouldDraw = false;
        }
    }
}

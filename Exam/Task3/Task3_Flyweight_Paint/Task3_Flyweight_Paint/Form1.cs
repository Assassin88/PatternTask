using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3_Flyweight_Paint
{
    public partial class MainForm : Form
    {
        Color CurrentColor = Color.Black;
        bool isPressed = false;
        Point CurrentPoint;
        Point PrevPoint;
        Graphics g;

        public MainForm()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            CurrentColor = FlyweightFactory.GetColor(tbColor.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPressed) 
            {
                PrevPoint = CurrentPoint;
                CurrentPoint = e.Location;
                for_paint();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isPressed = true;
            CurrentPoint = e.Location;
        }

        private void for_paint() 
        {
            Pen pen = new Pen(CurrentColor);
            g.DrawLine(pen, PrevPoint, CurrentPoint);
        }

        private void btnColorControl_Click(object sender, EventArgs e)
        {
            DialogResult d = colorDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                CurrentColor = colorDialog1.Color;
            }
        }
    }
}

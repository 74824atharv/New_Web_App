using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyWindowsApp
{
    public partial class Form1 : Form
    {
        private Point StartPoint;
        private Point EndPoint;

        public Form1()
        {
            Paint += new System.Windows.Forms.PaintEventHandler(OnPaint);
            MouseDown += new System.Windows.Forms.MouseEventHandler(OnMouseDown);
            MouseUp += new System.Windows.Forms.MouseEventHandler(OnMouseUp);
        }

        // Event handlers
        public void OnPaint(object sender, PaintEventArgs e)
        {
            // Add painting logic here
        }

        public void OnMouseDown(object sender, MouseEventArgs e)
        {
            StartPoint = new Point(e.X, e.Y);
        }

        public void OnMouseUp(object sender, MouseEventArgs e)
        {
            EndPoint = new Point(e.X, e.Y);
            Line l = new Line(StartPoint, EndPoint, "red", 3);
            Pen pen = new Pen(Color.FromArgb(255, 255, 0, 0));
            Graphics g = this.CreateGraphics();
            g.DrawLine(pen, l.StartPoint.X, l.StartPoint.Y, l.EndPoint.X, l.EndPoint.Y);
        }
    }

    public class Line
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public string Color { get; set; }
        public int Thickness { get; set; }

        public Line(Point startPoint, Point endPoint, string color, int thickness)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
            Color = color;
            Thickness = thickness;
        }
    }
}

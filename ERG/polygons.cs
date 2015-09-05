using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ERG
{
    class polygons
    {
        public void drawpolygononpanel(PictureBox p, string sequence, int resolution, Point polycenter, bool blackcircles)
        {
            int sides = resolution;
            int radius = (int)(polycenter.X * .66);
            Image i = p.Image;
            p.Image = drawregularpoly(sides, radius, polycenter, p.ClientSize, sequence, polycenter, blackcircles);
            if (i != null) i.Dispose();
        }

        private Bitmap drawregularpoly(int sides, int radius, Point center, Size canvassize, string seq, Point polycenter, bool blackcircles)
        {
            Point[] vertices = calcvertices(sides, radius, center);
            char[] sequence = seq.ToCharArray();
            Bitmap polygon = new Bitmap(canvassize.Width, canvassize.Height);
            using (Graphics g = Graphics.FromImage(polygon))
            {
                Pen pen = new Pen(Color.SlateGray, 4.0f);
                SolidBrush redbrush = new SolidBrush(Color.Red);
                SolidBrush blackbrush = new SolidBrush(Color.Black);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                if (vertices.Length > 1)
                {
                    g.DrawPolygon(pen, vertices);
                    for (int i = 0; i < sequence.Length; i++)
                    {
                        if (sequence[i] == '1')
                        {
                            g.FillEllipse(redbrush, vertices[i].X - 6, vertices[i].Y - 6, 12, 12);
                        }
                        else
                        {
                            if (blackcircles)
                            {
                                g.FillEllipse(blackbrush, vertices[i].X - 4, vertices[i].Y - 4, 8, 8);
                            }
                        }
                    }
                }
                else if (vertices.Length == 1)
                {
                    if (sequence[0] == '1') pen.Color = Color.Red;
                    g.DrawEllipse(pen, polycenter.X, polycenter.Y, 10, 10);
                }
            }
            return polygon;
        }

        private Point[] calcvertices(int sides, int radius, Point center)
        {
            List<Point> points = new List<Point>();
            float step = 360.0f / sides;
            float angle = 0;
            for (double i = 0; i < 360.0; i += step)
            {
                points.Add(degreestoXY(angle, radius, center));
                angle += step;
            }
            return points.ToArray();
        }

        private Point degreestoXY(float degrees, float radius, Point origin)
        {
            Point xy = new Point();
            double radians = degrees * Math.PI / 180.0;
            xy.X = (int)(Math.Cos(radians) * radius + origin.X);
            xy.Y = (int)(Math.Sin(-radians) * radius + origin.Y);
            return xy;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Isp223k___Paint
{
    public partial class Paint : Form
    {

        Color CurrentColor = Color.Black;
        bool isPressed = false;

        private string tool;
        private int width;
        private bool isFill;

        List<Point> points = new List<Point>();

        Point CurrentPoint;
        Point PrevPoint;
        Graphics g;

        Point currentFillPoint;

        private void paint_panel_MouseDown(object sender, MouseEventArgs e)
        {
            isPressed = true;
            CurrentPoint = e.Location;
            currentFillPoint = e.Location;
            Brush brush = new SolidBrush(CurrentColor);
            Pen p = new Pen(CurrentColor, width);
            switch (tool)
            {
                case "ellipse":
                    if (!isFill) g.DrawEllipse(p, CurrentPoint.X, CurrentPoint.Y, 150, 150);
                    else g.FillEllipse(brush, CurrentPoint.X, CurrentPoint.Y, 150, 150);
                    break;
                case "trapezoid":
                    if (!isFill)
                    {
                        g.DrawPolygon(p, new Point[] {
                            new Point(CurrentPoint.X - 150, CurrentPoint.Y - 100),
                            new Point(CurrentPoint.X - 250, CurrentPoint.Y + 100),
                            new Point(CurrentPoint.X + 250, CurrentPoint.Y + 100),
                            new Point(CurrentPoint.X + 150, CurrentPoint.Y - 100),
                        });
                    } 
                    else
                    {
                        g.FillPolygon(brush, new Point[] {
                            new Point(CurrentPoint.X - 150, CurrentPoint.Y - 100),
                            new Point(CurrentPoint.X - 250, CurrentPoint.Y + 100),
                            new Point(CurrentPoint.X + 250, CurrentPoint.Y + 100),
                            new Point(CurrentPoint.X + 150, CurrentPoint.Y - 100),
                        });
                    }
                    break;
                case "triangle":
                    if (!isFill)
                    {
                        g.DrawPolygon(p, new Point[] {
                            new Point(CurrentPoint.X + 50, CurrentPoint.Y - 100),
                            new Point(CurrentPoint.X, CurrentPoint.Y),
                            new Point(CurrentPoint.X + 50, CurrentPoint.Y)
                        });
                    }
                    else
                    {
                        g.FillPolygon(brush, new Point[] {
                            new Point(CurrentPoint.X + 50, CurrentPoint.Y - 100),
                            new Point(CurrentPoint.X, CurrentPoint.Y),
                            new Point(CurrentPoint.X + 50, CurrentPoint.Y)
                        });
                    }
                    break;
                case "polygon":
                    if (!isFill) g.DrawRectangle(p, CurrentPoint.X, CurrentPoint.Y, 150, 250);
                    else g.FillRectangle(brush, CurrentPoint.X, CurrentPoint.Y, 150, 250);
                    break;
                case "rectangle":
                    if (!isFill) g.DrawRectangle(p, CurrentPoint.X, CurrentPoint.Y, 150, 150);
                    else g.FillRectangle(brush, CurrentPoint.X, CurrentPoint.Y, 150, 150);
                    break;
                case "fill":
                    fill();
                    break;
            }
        }

        private void paint_panel_MouseMove(object sender, MouseEventArgs e)
        {
            PrevPoint = CurrentPoint;
            CurrentPoint = e.Location;

            if (isPressed)
            {
                if (tool.Equals("pen"))
                {
                    paint_simple(5);
                }
                else if (tool.Equals("lastik"))
                {
                    lastik(35);
                }
            }
        }

        private void paint_simple(int width)
        {
            Pen p = new Pen(CurrentColor, width);
            g.DrawLine(p, PrevPoint, CurrentPoint);
            points.Add(CurrentPoint);
        }

        private void lastik(int width)
        {
            Pen p = new Pen(paint_panel.BackColor, width);
            g.DrawLine(p, PrevPoint, CurrentPoint);
        }

        void fill()
        {
            if(points.ToArray().Length != 0)
            {
                g.FillClosedCurve(new SolidBrush(CurrentColor), points.ToArray());
                points.Clear();
            }
        }

        private void paint_panel_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed = false;
        }

        private void color_pick(object sender, EventArgs e)
        {
            DialogResult D = colorDialog1.ShowDialog();
            if (D == DialogResult.OK)
            {
                CurrentColor = colorDialog1.Color;
            }
        }

        public Paint()
        {
            tool = "pen";
            isFill = false;
            width = 2;
            InitializeComponent();
            g = paint_panel.CreateGraphics();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            paint_panel.Refresh();
        }

        private void color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                CurrentColor = colorDialog1.Color;
            }
        }

        private void lastik_button_Click(object sender, EventArgs e)
        {
            tool = "lastik";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isFill = checkBox1.Checked;
        }

        private void Pen_Click(object sender, EventArgs e)
        {
            tool = "pen";
        }

        private void fiil_button_Click(object sender, EventArgs e)
        {
            tool = "fill";
        }

        private void triangle_Click(object sender, EventArgs e)
        {
            tool = "triangle";
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            tool = "rectangle";
        }

        private void ellipse_Click(object sender, EventArgs e)
        {
            tool = "ellipse";
        }

        private void trapezoid_Click(object sender, EventArgs e)
        {
            tool = "trapezoid";
        }

        private void polygon_Click(object sender, EventArgs e)
        {
            tool = "polygon";
        }

        private void text_Click(object sender, EventArgs e)
        {
            tool = "text";
        }

        private void curva_Click(object sender, EventArgs e)
        {
            tool = "curva";
        }
    }
}
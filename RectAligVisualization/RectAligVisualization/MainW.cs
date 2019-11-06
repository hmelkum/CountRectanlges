using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RectAligVisualization
{
    public partial class MainW : Form
    {
        List<Point> board = new List<Point>();
        Random rd = new Random();

        public MainW()
        {
            InitializeComponent();
            this.MouseMove += MainW_MouseMove;
            this.MouseClick += MainW_MouseClick;
            this.Shown += MainW_Shown;
            
        }

        private void MainW_Shown(object sender, EventArgs e)
        {
            Thread thd = new Thread(InitialLook);
            thd.Start();
        }

        private void InitialLook()
        {
            Thread.Sleep(150);

            Graphics g = this.CreateGraphics();

            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    board.Add(new Point
                    (
                        60 * i,
                        60 * j
                    ));
                }
            }

            foreach (Point p in board)
            {
                g.DrawEllipse(Pens.LightGreen, p.X - 5, p.Y - 5, 10, 10);
                g.FillEllipse(Brushes.LightGreen, p.X - 5, p.Y - 5, 10, 10);
            }
        }

        private void MainW_Activated(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    board.Add(new Point
                    (
                        60 * i,
                        60 * j
                    ));
                }
            }

            foreach (Point p in board)
            {
                g.DrawEllipse(Pens.LightGreen, p.X - 5, p.Y - 5, 10, 10);
                g.FillEllipse(Brushes.LightGreen, p.X - 5, p.Y - 5, 10, 10);
            }
        }

        private void MainW_MouseClick(object sender, MouseEventArgs e)
        {
            string locString = $"({e.X},{e.Y})";
            Graphics g = this.CreateGraphics();

            if (e.Button == MouseButtons.Left && board.FindAll(x => x.X == e.X && x.Y == e.Y).Count == 0)
            {
                board.Add(new Point(e.X, e.Y));
                g.DrawString(locString, Font, Brushes.LightGreen, e.X, e.Y - Font.Height);
                g.DrawEllipse(Pens.LightGreen, e.X - 5, e.Y - 5, 10, 10);
                g.FillEllipse(Brushes.LightGreen, e.X - 5, e.Y - 5, 10, 10);
            }
            else if (e.Button == MouseButtons.Right && board.FindAll(x => x.X == e.X && x.Y == e.Y).Count > 0)
            {
                board.Remove(board.Find(x => x.X == e.X && x.Y == e.Y));
                g.FillRectangle(Brushes.Black, e.X, e.Y - Font.Height, locString.Length * Font.Size, Font.Height);
                g.DrawEllipse(Pens.Black, e.X - 5, e.Y - 5, 10, 10);
                g.FillEllipse(Brushes.Black, e.X - 5, e.Y - 5, 10, 10);
            }
        }

        private void MainW_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            string locString = String.Empty;

            locString = $"({e.X},{e.Y})";
            coordLbl.Text = locString;
        }

        private void conBtn_Click(object sender, EventArgs e)
        {
            Thread thd = new Thread(Logic);
            thd.Start();
        }

        private void Logic()
        {
            int n = 0;
            Graphics g = this.CreateGraphics();
            SortByXY(board);
            Color col;

            for (int i = 0; i < board.Count - 1; i++)
            {
                for (int j = i + 1; j < board.Count - 1; j++)
                {
                    if (board[i].IsNext(board[j]))
                    {
                        KeyValuePair<int, List<int[]>> pair = Point.MatchesByY(board[i], board[j], board.ToArray());

                        n += pair.Key;


                        int length = pair.Value.Count;

                        for (int h = 0; h < length; h++)
                        {
                            col = Color.FromArgb(rd.Next(255), rd.Next(255), rd.Next(255));
                            g.DrawRectangle(new Pen(col, 5), (float)pair.Value[h][0], (float)pair.Value[h][1], (float)pair.Value[h][2], (float)pair.Value[h][3]);
                            //g.FillRectangle(new SolidBrush(col), (float)pair.Value[h][0], (float)pair.Value[h][1], (float)pair.Value[h][2], (float)pair.Value[h][3]);
                            try
                            {
                                Thread.Sleep(secTb.Value);
                            }
                            catch { }
                        }
                    }
                }
                try
                {
                    rectNum.Text = n.ToString();
                }
                catch { };
            }
        }

        static private void SortByXY(List<Point> points)
        {
            Point temp;

            for (int j = 0; j < points.Count; j++)
            {
                for (int i = 0; i < points.Count - 1; i++)
                {
                    if (points[i].X > points[i + 1].X)
                    {
                        temp = points[i];
                        points[i] = points[i + 1];
                        points[i + 1] = temp;
                    }
                    else if (points[i].X == points[i + 1].X)
                    {
                        if (points[i].Y > points[i + 1].Y)
                        {
                            temp = points[i];
                            points[i] = points[i + 1];
                            points[i + 1] = temp;
                        }
                    }
                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int x = int.Parse(xTb.Text);
            int y = int.Parse(yTb.Text);
            board.Add(new Point(x, y));
            Graphics g = this.CreateGraphics();

            string locString = $"({x},{y})";
            g.DrawString(locString, Font, Brushes.LightGreen, x, y - Font.Height);
            g.DrawEllipse(Pens.LightGreen, x - 5, y - 5, 10, 10);
            g.FillEllipse(Brushes.LightGreen, x - 5, y - 5, 10, 10);

            xTb.Text = "";
            yTb.Text = "";
        }

        private void restBtn_Click(object sender, EventArgs e)
        {
            rectNum.Text = "None";
        }

        private void refBtn_Click(object sender, EventArgs e)
        {
            board.Clear();
            this.CreateGraphics().Clear(Color.Black);
            rectNum.Text = "None";
        }

        private void secTb_Scroll(object sender, EventArgs e)
        {
            secLbl.Text = secTb.Value.ToString();
        }

    }
}

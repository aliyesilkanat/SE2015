using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;
using System.Drawing.Drawing2D;

namespace SE2015.Logical_Layer
{
    class KaldiracExperiment
    {


        public Point drawInitial(System.Windows.Forms.GroupBox groupBoxExperiment, int tubeLength,
            int forcePosition,
            int massPosition,
            int forceNewton,
            int massNewton,
            int supportPosition)
        {

            /*
             *      
              ||||||||||||||||||||
              |                  |a
              |                  |
              ||||||||||||||||||||
              <<<<<<b
             * 
             * 
             * 
                    |       |
                  |   |     |c
                |       |   |
             *  <<<d
             */
            int centerXOfGroupBox = groupBoxExperiment.Size.Width / 2;
            int centerYOfGroupBox = groupBoxExperiment.Size.Height / 2;


            int a = 30;
            int b = 300;
            int c = 50;
            int d = 40;

            int lineSpace = (2 * b) / tubeLength;

            Pen blackPen = new Pen(Color.Black);
            Graphics formGraphics = groupBoxExperiment.CreateGraphics();

            formGraphics.DrawRectangle(blackPen, centerXOfGroupBox - b, centerYOfGroupBox, 2 * b, a);
            List<Point> pointsUpperOnTube = new List<Point>();
            List<Point> pointsLowerOnTube = new List<Point>();
            drawLines(tubeLength, centerXOfGroupBox, centerYOfGroupBox, a, b, lineSpace, blackPen, formGraphics, pointsUpperOnTube, pointsLowerOnTube);
            drawRectangle(pointsLowerOnTube[supportPosition - 1], a, d, c, formGraphics);
            drawForceArrow(forcePosition, blackPen, formGraphics, pointsUpperOnTube, forceNewton);
            drawMass(massPosition, formGraphics, pointsUpperOnTube, massNewton);




            blackPen.Dispose();
            formGraphics.Dispose();
            return pointsLowerOnTube[supportPosition - 1];
        }

        private static void drawMass(int massPosition, Graphics formGraphics, List<Point> pointsUpperOnTube, int massNewton)
        {
            Point item = pointsUpperOnTube[massPosition - 1];
            formGraphics.FillRectangle(Brushes.Black, item.X - 5, item.Y - 10, 10, 10);

            string drawString = "" + massNewton + "N";
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 12);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            formGraphics.DrawString(drawString, drawFont, drawBrush, item.X - 15, item.Y - 40);
        }

        private static void drawForceArrow(int forcePosition, Pen blackPen, Graphics formGraphics, List<Point> pointsUpperOnTube, int forceNewton)
        {


            Point item = pointsUpperOnTube[forcePosition - 1];
            string drawString = "" + forceNewton + "N";
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 12);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

            formGraphics.DrawString(drawString, drawFont, drawBrush, item.X - 15, item.Y - 40);

            formGraphics.DrawLine(blackPen, item, new Point(item.X - 5, item.Y - 8));
            formGraphics.DrawLine(blackPen, item, new Point(item.X + 5, item.Y - 8));
            formGraphics.DrawLine(blackPen, item, new Point(item.X, item.Y - 20));
        }

        private static void drawLines(int lines, int centerXOfGroupBox, int centerYOfGroupBox, int a, int b, int lineSpace, Pen blackPen, Graphics formGraphics, List<Point> pointsUpperOnTube, List<Point> pointsLowerOnTube)
        {
            for (int i = 1; i < lines; i++)
            {

                if (i == 1)
                {
                    pointsUpperOnTube.Add(new Point(centerXOfGroupBox - b + lineSpace / 2, centerYOfGroupBox));
                    pointsLowerOnTube.Add(new Point(centerXOfGroupBox - b + lineSpace / 2, centerYOfGroupBox + a));

                }
                else
                {
                    pointsUpperOnTube.Add(new Point(pointsUpperOnTube.Last().X + lineSpace, centerYOfGroupBox));
                    pointsLowerOnTube.Add(new Point(pointsLowerOnTube.Last().X + lineSpace, centerYOfGroupBox + a));
                }


                formGraphics.DrawLine(blackPen, new Point(centerXOfGroupBox - b + lineSpace * i, centerYOfGroupBox), new Point(centerXOfGroupBox - b + lineSpace * i, centerYOfGroupBox + a));

            }
            pointsUpperOnTube.Add(new Point(pointsUpperOnTube.Last().X + lineSpace, centerYOfGroupBox));
            pointsLowerOnTube.Add(new Point(pointsLowerOnTube.Last().X + lineSpace, centerYOfGroupBox + a));

        }

        private static void drawRectangle(Point lowerPosition, int c, int e, int f, Graphics formGraphics)
        {
            formGraphics.FillPolygon(Brushes.Red, new Point[] { new Point(lowerPosition.X, lowerPosition.Y), new Point(lowerPosition.X - e, lowerPosition.Y + f), new Point(lowerPosition.X + e, lowerPosition.Y + f) });
        }

        public void drawExperiment(System.Windows.Forms.GroupBox groupBoxExperiment, int tubeLength,
            int forcePosition,
            int massPosition,
            int forceNewton,
            int massNewton,
            int supportPosition)
        {
            Point supportPoint = drawInitial(groupBoxExperiment, tubeLength, forcePosition, massPosition, forceNewton, massNewton, supportPosition);
            Thread.Sleep(1000);
            // |forcePosition - supportPosition| * forceNewton =? |massPosition- supportPosition|*massNewton
            int forceTorque = Math.Abs(forcePosition - supportPosition) * forceNewton;
            int massTorque = Math.Abs(massPosition - supportPosition) * massNewton;
            int left = 0;
            int right = 0;
            if (forcePosition > supportPosition) { right = forceTorque; }
            else
            {
                left = forceTorque;
            }
            if (massPosition > supportPosition) { right = massTorque; }
            else
            {
                left = massTorque;
            }

            if (left > right)
            {

                // -1 means negative angle
               rotate(groupBoxExperiment, tubeLength, forcePosition, massPosition, forceNewton, massNewton, supportPoint,-1);
            }
            else if (right > left)
            {   // 1 means positive angle
                rotate(groupBoxExperiment, tubeLength, forcePosition, massPosition, forceNewton, massNewton, supportPoint, 1);
            }

        }

        public void rotate(System.Windows.Forms.GroupBox groupBoxExperiment, int tubeLength, int forcePosition, int massPosition, int forceNewton, int massNewton, Point supportPoint,int angleWay)
        {
            for (int i = 1; i <= 20; i++)
            {

                /*
                *      
                 ||||||||||||||||||||
                 |                  |a
                 |                  |
                 ||||||||||||||||||||
                 <<<<<<b
                * 
                * 
                * 
                       |       |
                     |   |     |c
                   |       |   |
                *  <<<d
                */
                int centerXOfGroupBox = groupBoxExperiment.Size.Width / 2;
                int centerYOfGroupBox = groupBoxExperiment.Size.Height / 2;


                int a = 30;
                int b = 300;
                int c = 50;
                int d = 40;

                int lineSpace = (2 * b) / tubeLength;

                Pen blackPen = new Pen(Color.Black);
                Graphics formGraphics = groupBoxExperiment.CreateGraphics();
                formGraphics.Clear(SystemColors.Control);

                List<Point> pointsUpperOnTube = new List<Point>();
                List<Point> pointsLowerOnTube = new List<Point>();



                drawRectangle(supportPoint, a, d, c, formGraphics);
                using (Matrix m = new Matrix())
                {
                    m.RotateAt(i * angleWay*1.25F, new PointF(supportPoint.X, supportPoint.Y));
                    formGraphics.Transform = m;
                }
                drawLines(tubeLength, centerXOfGroupBox, centerYOfGroupBox, a, b, lineSpace, blackPen, formGraphics, pointsUpperOnTube, pointsLowerOnTube);

                drawForceArrow(forcePosition, blackPen, formGraphics, pointsUpperOnTube, forceNewton);
                drawMass(massPosition, formGraphics, pointsUpperOnTube, massNewton);

                drawTube(centerXOfGroupBox, centerYOfGroupBox, a, b, blackPen, formGraphics);


                blackPen.Dispose();
                formGraphics.Dispose();
                Thread.Sleep(125);
            }
           
        }

        private static void drawTube(int centerXOfGroupBox, int centerYOfGroupBox, int a, int b, Pen blackPen, Graphics formGraphics)
        {
            formGraphics.DrawRectangle(blackPen, centerXOfGroupBox - b, centerYOfGroupBox, 2 * b, a);
        }
    }
}

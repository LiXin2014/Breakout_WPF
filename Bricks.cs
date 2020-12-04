using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Breakout
{
    public class Bricks
    {
        public List<Rectangle> BrickList { get; set; } = new List<Rectangle>();

        private Canvas gameAreaCanvas;

        public Bricks(Canvas gameAreaCanvas)
        {
            this.gameAreaCanvas = gameAreaCanvas;
            DrawBricks();
        }

        private void DrawBricks()
        {
            double width = this.gameAreaCanvas.ActualWidth / 10;
            double nextX = 0;
            double nextY = 0;

            for (int level = 0; level < 5; level++)
            {
                for (int col = 0; col < 10; col++)
                {
                    Rectangle rec = new Rectangle();
                    rec.Width = width;
                    rec.Height = Constants.BrickHeight;
                    SolidColorBrush colorBrush = new SolidColorBrush(Colors.Snow);
                    SolidColorBrush borderBrush = new SolidColorBrush(Colors.Gray);
                    rec.Fill = colorBrush;
                    rec.Stroke = borderBrush;
                    this.gameAreaCanvas.Children.Add(rec);
                    Canvas.SetTop(rec, nextY);
                    Canvas.SetLeft(rec, nextX);

                    nextX += width;
                }

                nextX = 0;
                nextY += Constants.BrickHeight;
            }
        }
    }
}

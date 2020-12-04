using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Breakout
{
    public class Paddle
    {
        private Canvas gameAreaCanvas;

        public Paddle(Canvas gameAreaCanvas)
        {
            this.gameAreaCanvas = gameAreaCanvas;
            DrawPaddle();
        }

        private void DrawPaddle()
        {
            double width = this.gameAreaCanvas.ActualWidth / 5;

            Rectangle rec = new Rectangle();
            rec.Width = width;
            rec.Height = Constants.PaddleHeight;
            SolidColorBrush colorBrush = new SolidColorBrush(Colors.Moccasin);
            SolidColorBrush borderBrush = new SolidColorBrush(Colors.Gray);
            rec.Fill = colorBrush;
            rec.Stroke = borderBrush;
            this.gameAreaCanvas.Children.Add(rec);
            Canvas.SetTop(rec, this.gameAreaCanvas.ActualHeight - Constants.PaddleHeight - 5);
            Canvas.SetLeft(rec, this.gameAreaCanvas.ActualWidth / 2 - width / 2);
        }
    }
}

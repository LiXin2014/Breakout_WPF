
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Breakout
{
    public class Ball
    {
        private Canvas gameAreaCanvas;

        public Ball(Canvas gameAreaCanvas)
        {
            this.gameAreaCanvas = gameAreaCanvas;
            DrawBall();
        }

        private void DrawBall()
        {
            Ellipse ball = new Ellipse();
            ball.Width = Constants.BallHeight;
            ball.Height = Constants.BallHeight;

            SolidColorBrush colorBrush = new SolidColorBrush(Colors.Moccasin);
            SolidColorBrush borderBrush = new SolidColorBrush(Colors.Gray);
            ball.Fill = colorBrush;
            ball.Stroke = borderBrush;
            this.gameAreaCanvas.Children.Add(ball);
            Canvas.SetTop(ball, this.gameAreaCanvas.ActualHeight - Constants.PaddleHeight - Constants.BallHeight - 5);
            Canvas.SetLeft(ball, this.gameAreaCanvas.ActualWidth / 2);
        }
    }
}

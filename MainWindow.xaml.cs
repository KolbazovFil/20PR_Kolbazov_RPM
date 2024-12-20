using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
namespace _20PR_Kolbazov_RPM
{
    public partial class MainWindow : Window
    {
        private void StartAnimation_Click(object sender, RoutedEventArgs e)
        {
            // Запускаем анимацию для каждого элемента
            Storyboard circleStoryboard = (Storyboard)FindResource("CircleAnimation");
            circleStoryboard.Begin();

            Storyboard rectangleStoryboard = (Storyboard)FindResource("RectangleAnimation");
            rectangleStoryboard.Begin();

            Storyboard textStoryboard = (Storyboard)FindResource("TextAnimation");
            textStoryboard.Begin();
        }

        private void StopAnimation_Click(object sender, RoutedEventArgs e)
        {
            // Останавливаем анимацию для каждого элемента
            Storyboard circleStoryboard = (Storyboard)FindResource("CircleAnimation");
            circleStoryboard.Stop();

            Storyboard rectangleStoryboard = (Storyboard)FindResource("RectangleAnimation");
            rectangleStoryboard.Stop();

            Storyboard textStoryboard = (Storyboard)FindResource("TextAnimation");
            textStoryboard.Stop();
        }

        private void ResetAnimation_Click(object sender, RoutedEventArgs e)
        {
            // Возвращаем все элементы в начальное состояние
            animatedCircle.Width = 100;
            animatedCircle.Height = 100;

            animatedRectangle.Width = 100;

            animatedRectangle.Height = 100;

            animatedText.Foreground = new SolidColorBrush(Colors.Red);

            StopAnimation_Click(sender, e);
        }
    }
}
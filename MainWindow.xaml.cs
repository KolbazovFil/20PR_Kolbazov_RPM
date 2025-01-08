using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
namespace _20PR_Kolbazov_RPM
{
    public partial class MainWindow : Window
    {
        private DoubleAnimation ellipseAnimation;
        private DoubleAnimation rectangleAnimation;
        private ColorAnimation textAnimation;
        public MainWindow()
        {
            InitializeComponent();
            Animation();
        }
        private void Animation()
        {
            ellipseAnimation = new DoubleAnimation  // Анимация эллипса
            {
                From = 50,
                To = 200,
                Duration = TimeSpan.FromSeconds(2),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            rectangleAnimation = new DoubleAnimation    // Анимация прямоугольника
            {
                From = 0,
                To = 300,
                Duration = TimeSpan.FromSeconds(2),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            textAnimation = new ColorAnimation  // Анимация текста
            {
                From = Colors.Black,
                To = Colors.Coral,
                Duration = TimeSpan.FromSeconds(1),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };
            
            Text.Foreground = new SolidColorBrush(Colors.Black);    // Установка начального цвета
        }
        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            Ellipse.BeginAnimation(Ellipse.WidthProperty, ellipseAnimation);
            Ellipse.BeginAnimation(Ellipse.HeightProperty, ellipseAnimation);
            Rectangle.BeginAnimation(Canvas.LeftProperty, rectangleAnimation);
            Text.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, textAnimation);
        }
        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            var ellipseWidth = Ellipse.Width;
            var ellipseHeight = Ellipse.Height;
            var rectangleLeft = Canvas.GetLeft(Rectangle);
            var currentColor = ((SolidColorBrush)Text.Foreground).Color;

            // Остановка анимации и установка текущих значений
            Ellipse.BeginAnimation(Ellipse.WidthProperty, null);
            Ellipse.Width = ellipseWidth;
            Ellipse.BeginAnimation(Ellipse.HeightProperty, null);
            Ellipse.Height = ellipseHeight;
            Rectangle.BeginAnimation(Canvas.LeftProperty, null);
            Canvas.SetLeft(Rectangle, rectangleLeft);
            Text.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, null);
            Text.Foreground = new SolidColorBrush(currentColor);
        }
        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            // Остановка анимаций
            Ellipse.BeginAnimation(Ellipse.WidthProperty, null);
            Ellipse.BeginAnimation(Ellipse.HeightProperty, null);
            Rectangle.BeginAnimation(Canvas.LeftProperty, null);
            Text.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, null);
            // Сброс значений
            Ellipse.Width = 50;
            Ellipse.Height = 50;
            Canvas.SetLeft(Rectangle, 150);
            Text.Foreground = new SolidColorBrush(Colors.Black);
        }
    }
}
using System;
using System.Windows;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace PulsarApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 200;
            animation.To = 100;
            animation.Duration = new Duration(TimeSpan.FromSeconds(1));
            circle.BeginAnimation(Ellipse.WidthProperty, animation);

            DoubleAnimation animation2 = new DoubleAnimation();
            animation2.From = 200;
            animation2.To = 100;
            animation2.Duration = new Duration(TimeSpan.FromSeconds(1));
            circle.BeginAnimation(Ellipse.HeightProperty, animation2);
        }
    }
}
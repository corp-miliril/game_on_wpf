using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace LightHeroes3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Point point = new Point(20, 30);
            Player p = new Player("Hero");
            p.Shape.Margin = new Thickness(point.X, point.Y, 0, 0);

            Point point2 = new Point(680, 30);
            Player p2 = new Player("Enemy");
            p2.Shape.Margin = new Thickness(point2.X, point2.Y, 0, 0);

            InitializeComponent();
            Menu.Children.Add(p.Shape);
            Menu.Children.Add(p2.Shape);
        }

        private void Button_start_game_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            GameWindow win1 = new GameWindow(this);
            win1.Show();
        }
    }
}

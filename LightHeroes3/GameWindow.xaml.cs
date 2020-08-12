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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace LightHeroes3
{
    /// <summary>
    /// Логика взаимодействия для GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        private DispatcherTimer timer = new DispatcherTimer();
        MainWindow main_window;


        public GameWindow(MainWindow main_window)
        {
            this.main_window = main_window;
            timer.Tick += new EventHandler(Engine);
            timer.Interval = TimeSpan.FromMilliseconds(20);
            timer.Start();

            Point point = new Point(30, 30);
            Tank t1 = new Tank();
            Soldier s1 = new Soldier();
            Archer a1 = new Archer();
            Archangel ar1 = new Archangel();

            t1.Shape.Margin = new Thickness(point.X, point.Y, 0, 0);
            s1.Shape.Margin = new Thickness(point.X + 80, point.Y, 0, 0);
            a1.Shape.Margin = new Thickness(point.X + 160, point.Y, 0, 0);
            ar1.Shape.Margin = new Thickness(point.X + 240, point.Y, 0, 0);

            InitializeComponent();

            this.Closed += GameWindow_Closed;

            GameArea.Children.Add(t1.Shape);
            GameArea.Children.Add(s1.Shape);
            GameArea.Children.Add(a1.Shape);
            GameArea.Children.Add(ar1.Shape);
        }

        public void Engine(object sender, EventArgs e)
        {

        }

        private void GameWindow_Closed(object sender, EventArgs e)
        {
            main_window.Show();
        }
    }
}

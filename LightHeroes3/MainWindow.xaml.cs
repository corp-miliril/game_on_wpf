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
        DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            timer.Tick += new EventHandler(Engine);
            timer.Interval = TimeSpan.FromMilliseconds(20);
            timer.Start();
            InitializeComponent();
        }

        private void GameArea_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void GameArea_KeyUp(object sender, KeyEventArgs e)
        {

        }
        public void Engine(object sender, EventArgs e) {
            Tank t1 = new Tank();
            GameArea.Children.Add(t1.Shape);
            Canvas.SetLeft(t1.Shape, 200);
        }
    }
}

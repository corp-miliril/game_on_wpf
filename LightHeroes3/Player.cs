using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LightHeroes3
{
    public class Player
    {
        public List<Unit> units = new List<Unit> { };
        public ImageBrush Skin = new ImageBrush();
        public Rectangle Shape = new Rectangle() { Width = 80, Height = 80 };


        public Player(string hero_type) {
            this.Skin.ImageSource = hero_type == "Hero" ? new BitmapImage(new Uri("Images/hero.png", UriKind.Relative)) : new BitmapImage(new Uri("Images/hero2.png", UriKind.Relative));
            this.Shape.Fill = this.Skin;
        }
    }
}

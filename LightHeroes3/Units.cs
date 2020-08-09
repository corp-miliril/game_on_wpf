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
    abstract class Unit
    {
        public int damage;
        public int hp;
        public int defence;
        //public int coords;
        public int cost;
        public ImageBrush Skin = new ImageBrush();
        public Rectangle Shape = new Rectangle();

        abstract public void Attack(Unit u);
    }

   

    class Soldier: Unit
    {
        public Soldier() {
            this.damage = 1;
            this.hp = 10;
            this.defence = 10;
            this.cost = 10;
            this.Skin.ImageSource = new BitmapImage(new Uri("Images/soldier.jpg", UriKind.Relative));
            this.Shape.Fill = this.Skin;
        }

        public override void Attack(Unit u)
        {
            throw new NotImplementedException();
        }
    }


    class Tank : Unit
    {
        public Tank()
        {
            this.damage = 1;
            this.hp = 10;
            this.defence = 10;
            this.cost = 10;
            this.Skin.ImageSource = new BitmapImage(new Uri("Images/tank.jpg", UriKind.Relative));
            this.Shape.Fill = this.Skin;
        }

        public override void Attack(Unit u)
        {
            throw new NotImplementedException();
        }
    }


    class Archer : Unit
    {
        public Archer()
        {
            this.damage = 1;
            this.hp = 10;
            this.defence = 10;
            this.cost = 10;
            this.Skin.ImageSource = new BitmapImage(new Uri("Images/archer.jpg", UriKind.Relative));
            this.Shape.Fill = this.Skin;
        }

        public override void Attack(Unit u)
        {
            throw new NotImplementedException();
        }
    }


    class Archangel : Unit
    {
        public Archangel()
        {
            this.damage = 1;
            this.hp = 10;
            this.defence = 10;
            this.cost = 10;
            this.Skin.ImageSource = new BitmapImage(new Uri("Images/archangel.jpg", UriKind.Relative));
            this.Shape.Fill = this.Skin;
        }

        public override void Attack(Unit u)
        {
            throw new NotImplementedException();
        }
    }
}

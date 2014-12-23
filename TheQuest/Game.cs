using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    class Game
    {
        public IEnumerable<Enemy> Enemies { get; private set; }
        public Weapon WeaponInRoom { get; private set; }
        private Player player;
        public Point PlayerLocation { get { return player.location; } }
        public int PlayerHitPoints { get { return player.hitPoints; } }
        public IEnumerable<string> PlayerWeapons { get { return player.weapons; } }
        private int level = 0;
        public int Level { get { return this.level; } }
        private Rectangle boundaries;
        public Rectangle Boundaries { get { return this.boundaries; } }

        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            player = new Player(this, new Point(boundaries.Left + 10, boundaries.Top + 70));
        }

        public void Move(Direction direction, Random random)
        {
            player.Move(direction);
            foreach (Enemy enemy in this.Enemies)
            {
                enemy.Move(random);
            }
        }

        public void Equip(string weaponName)
        {
            player.Equip(weaponName);
        }

        public bool CheckPlayerInventory(string weaponName)
        {
            return player.Weapons.Contains(weaponName);
        }

        public void HitPlayer(int maxDamage, Random random)
        {
            player.Hit(maxDamage, random);
        }

        public void IncreasePlayerHealth(int health, Random random)
        {
            player.IncreaseHealth(health, random);
        }

        public void Attack(Direction direction, Random random)
        {
            player.Attack(direction, random);
            foreach (Enemy enemy in this.Enemies)
	        {
                enemy.Move(random);
	        }
        }

        private Point getRandomLocation(Random random)
        {
            return new Point(
                this.boundaries.Left + random.Next(this.boundaries.Right / 10 - this.boundaries.Left / 10) * 10,
                this.boundaries.Top + random.Next(this.boundaries.Bottom / 10 - this.boundaries.Top / 10) * 10);
        }

        public void NewLevel(Random random)
        {
            level++;
            switch (level)
            {
                case 1:
                    this.Enemies = new List<Enemy>() { new Bat(this, getRandomLocation(random)) };
                    WeaponInRoom = new Sword(this, getRandomLocation(random));
                    break;
            }
        }
    }
}

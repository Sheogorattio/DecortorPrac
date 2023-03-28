using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecortorPrac
{
    public abstract class HeroDecorator:MainCharacter
    {
        public MainCharacter Hero { get; }
        public HeroDecorator(MainCharacter hero)
        {
            this.Hero = hero;
        }

       // abstract public MainCharacter getHero();
    }
    public class HumanWarriorDecor:HeroDecorator
    {
        public HumanWarriorDecor(Human hero) : base(hero)
        {
            hero.Name = "Human warrior";
            hero.Attack = 40;
            hero.Speed = 30;
            hero.Health = 200;
            hero.Armor = 20;
        }
    }
    public class HumanSwordBearer : HeroDecorator
    {
        public HumanSwordBearer(Human hero):base(hero)
        {
            hero.Name = "Sword bearer";
            hero.Attack = 80;
            hero.Speed = 20;
            hero.Health = 250;
            hero.Armor = 60;
        }
    }

    public class ElfWarrior : HeroDecorator
    {
        public ElfWarrior(Elf hero):base (hero) 
        {
            hero.Name = "Warrior";
            hero.Attack = 35;
            hero.Speed = 20;
            hero.Health = 200;
            hero.Armor = 20;
        }
    }
    public class ElfMagician : HeroDecorator
    {
        public ElfMagician(Elf hero) : base(hero)
        {
            hero.Attack = 45;
            hero.Speed = 30;
            hero.Health = 150;
            hero.Armor = 30;
        }
    }
}

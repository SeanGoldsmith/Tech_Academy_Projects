using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace takeTwo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Random generator = new Random();
            Dice someDice = new Dice();

            Character hero = new Character();
            Character monster = new Character();

            hero.Name = "Hero";
            hero.Health = 100;
            hero.MaxDamage = 20;
            hero.AttackBonus = false;

            monster.Name = "Monster";
            monster.Health = 100;
            monster.MaxDamage = 20;
            monster.AttackBonus = false;

            while (hero.Health > 0 && monster.Health > 0)
            {
                monster.Defend(hero.Attack(someDice, generator));
                hero.Defend(monster.Attack(someDice, generator));

                printHealth(hero);
                printHealth(monster);
            }
            displayResult(hero,monster);
        }

        public void printHealth(Character character)
        {
            resultLabel.Text += String.Format("The Stats for {0} are as follows:<br>Health: {1}<br>Max Damage: {2}<br>" +
                "Attack Bonus: {3}<br><br>", character.Name, character.Health, character.MaxDamage, character.AttackBonus);
            if (character.Name == "Monster")
            {
                resultLabel.Text += "---------------------<br><br><br>";
            }
        }
        public void displayResult(Character one, Character two)
        {
            if (!(one.Health <= 0 && two.Health <= 0))
            {
                if (one.Health > two.Health)
                {
                    resultLabel.Text += String.Format("The {0} has killed the {1}!", one.Name, two.Name);
                }
                else resultLabel.Text += String.Format("The {0} has killed the {1}!", two.Name, one.Name);
            }
            else resultLabel.Text += "Everyone is dead.";
        }
    }
    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int MaxDamage { get; set; }
        public bool AttackBonus { get; set; }

        public int Attack(Dice somedice, Random generator)
        {
            int damagedone = somedice.Roll(generator, this.MaxDamage);
            return damagedone;
        }
        public void Defend(int damage)
        {
            this.Health -= damage;
        }
    }
    public class Dice
    {
        public int sides { get; set; }

        public int Roll(Random generator, int maxdamage)
        {
            this.sides = maxdamage;
            return generator.Next(1, sides);
        }
    }
}
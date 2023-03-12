using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearTheTower
{
    class Vampire:IEnemy
    {
        int strength;
        GameContext context;

        public Vampire(int strength, GameContext context)
        {
            this.strength = strength;
            this.context = context;
        }
        public void SetStrength(int strength)
        {
            this.strength = strength;
        }
        public bool Fight(char option)
        {
            if(option == '1')
            {
                Random random = new Random(Guid.NewGuid().GetHashCode());
                int seduce_output = random.Next(2);
                if(seduce_output == 0)
                {
                    context.GetPlayer().decreaseHP(strength);
                    return false;
                }
                if(seduce_output == 1)
                {
                    context.GetPlayer().increaseShillings(2 * strength);
                    return true;
                }
            }
            if(option == '2')
            {
                if (context.GetPlayer().GetMP() > strength)
                {
                    context.GetPlayer().increaseShillings((int)Math.Floor(0.5 * strength));
                    return true;
                }
                else
                {
                    context.GetPlayer().decreaseHP((int)Math.Floor(0.5 * strength));
                    return false;
                }
            }
            return false;
        }
        public int GetStrength()
        {
            return strength;
        }
        public char CallEnemyMenu()
        {
            context.GetUserInterfaceHandler().showVampireMenu(this);
            ConsoleKeyInfo choice = Console.ReadKey(true);
            if(choice.KeyChar== '1')
            {
                return '1';
            }
            else if(choice.KeyChar == '2')
            {
                return '2';
            }
            else
            {
                return '2';
            }
            
        }

    }
}

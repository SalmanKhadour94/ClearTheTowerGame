using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearTheTower
{
    class Warewolf:IEnemy
    {
        int strength;
        GameContext context;

        public Warewolf(int strength, GameContext context)
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
            if (option == '1')
            {
                int num_of_wa_pot = context.GetPlayer().CheckBackpack(CollectableType.WarewolfAntidotePotion);
                if(num_of_wa_pot > 0)
                {
                    context.GetPlayer().TakeFromBackpack(CollectableType.WarewolfAntidotePotion);
                    context.GetPlayer().increaseShillings(2 * strength);
                    return true;
                }
                else
                {
                    context.GetPlayer().decreaseHP(context.GetPlayer().GetHP());
                    return false;
                }
                
            }
            if (option == '2')
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

            context.GetUserInterfaceHandler().showWarewolfMenu(this);
            ConsoleKeyInfo choice = Console.ReadKey(true);
            if (choice.KeyChar == '1')
            {
                return '1';
            }
            else if (choice.KeyChar == '2')
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearTheTower
{
    class Snake : IEnemy
    {
        int strength;
        GameContext context;

        public Snake(int strength, GameContext context)
        {
            this.strength = strength;
            this.context = context;
        }
        public bool Fight(char option)
        {
            if (context.GetPlayer().GetMP() > strength)
            {
                if(strength<=20)
                {
                    context.GetPlayer().AddToBackpack(CollectableType.NormalSmallPotion);
                }
                else if(strength<=40)
                {
                    context.GetPlayer().AddToBackpack(CollectableType.NormalMediumPotion);
                }
                else
                {
                    context.GetPlayer().AddToBackpack(CollectableType.NormalLargePotion);
                }
                return true;
            }
            else
            {
                context.GetPlayer().decreaseHP((int)Math.Floor(0.5 * strength));
                return false;
            }
        }
        public void SetStrength(int strength)
        {
            this.strength = strength;
        }
        public int GetStrength()
        {
            return strength;
        }
        public char CallEnemyMenu()
        {
            context.GetUserInterfaceHandler().showSnakeMenu(this);
            return '0';
        }
       
    }
}

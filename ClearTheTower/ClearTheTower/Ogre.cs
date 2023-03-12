using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearTheTower
{
    class Ogre : IEnemy
    {
        int strength;
        GameContext context;

        public Ogre(int strength, GameContext context)
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
            if (context.GetPlayer().GetMP() > strength)
            {
                context.GetPlayer().AddToBackpack(CollectableType.FrogAntidotePotion);                
                return true;
            }
            else
            {
                context.GetPlayer().decreaseHP(strength);
                return false;
            }
        }
        public int GetStrength()
        {
            return strength;
        }
        public char CallEnemyMenu()
        {
            context.GetUserInterfaceHandler().showOgreMenu(this);
            return '0';
        }
    }
}

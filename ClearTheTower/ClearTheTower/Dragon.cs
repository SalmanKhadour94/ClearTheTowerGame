using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearTheTower
{
    class Dragon:IEnemy
    {
        int strength;
        GameContext context;

        public Dragon(int strength, GameContext context)
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
                if (strength <= 15)
                {
                    context.GetPlayer().AddToBackpack(CollectableType.NormalSmallWeapon);
                }
                else if (strength <= 30)
                {
                    context.GetPlayer().AddToBackpack(CollectableType.NormalMediumWeapon);
                }
                else
                {
                    context.GetPlayer().AddToBackpack(CollectableType.NormalLargeWeapon);
                }
                return true;
            }
            else
            {
                context.GetPlayer().decreaseHP((int)Math.Floor(0.75 * strength));
                return false;
            }
        }
        public int GetStrength()
        {
            return strength;
        }
        public char CallEnemyMenu()
        {
            context.GetUserInterfaceHandler().showDragonMenu(this);
            return '0';
        }
    }
}

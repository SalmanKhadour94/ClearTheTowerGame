using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearTheTower
{
    class Troll:IEnemy
    {
        int strength;
        GameContext context;

        public Troll(int strength, GameContext context)
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
            if(context.GetPlayer().GetMP()> strength)
            {
                context.GetPlayer().increaseShillings((int)Math.Floor(0.5*strength));
                return true;
            }
            else
            {
                context.GetPlayer().decreaseHP((int)Math.Floor(0.5 * strength));
                return false;
            }
            
        }
        public char CallEnemyMenu()
        {
            context.GetUserInterfaceHandler().showTrollMenu(this);
            return '0';
        }
        public int GetStrength()
        {
            return strength;
        }

        public override string ToString()
        {
            return "You met a troll!";
        }
    }
}

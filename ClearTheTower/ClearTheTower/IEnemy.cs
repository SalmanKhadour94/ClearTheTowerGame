using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearTheTower
{
    interface IEnemy
    {
        bool Fight(char option);
        int GetStrength();
        void SetStrength(int strength);
        char CallEnemyMenu();
    }
}

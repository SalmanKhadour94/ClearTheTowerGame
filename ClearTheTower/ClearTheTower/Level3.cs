using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearTheTower
{
    class Level3 : ILevel
    {
        GameContext context;
        IEnemy enemy;
        EnemyCreator enemyCreator;

        public Level3(GameContext context, EnemyCreator creator)
        {
            this.context = context;
            this.enemyCreator = creator;
        }
        public bool fightTheBeast()
        {
            if (enemy == null)
            {
                enemy = enemyCreator.GenerateEnemy(EnemyLevelType.MiddleLevel);
            }
            char option = enemy.CallEnemyMenu();
            bool result = enemy.Fight(option);
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearTheTower
{
    public enum EnemyLevelType
    {
        LowLevel,
        MiddleLevel,
        HighLevel
    }
     class EnemyCreator
    {
        int strength;
        EnemyLevelType type;
        GameContext context;
        List<IEnemy> enemyList = new List<IEnemy>();
        public EnemyCreator(GameContext context)
        {
            this.context = context;
            enemyList.Add(new Warewolf(strength, context));
            enemyList.Add(new Snake(strength, context));
            enemyList.Add(new Troll(strength, context));
            enemyList.Add(new Vampire(strength, context));
            enemyList.Add(new Ogre(strength, context));
            enemyList.Add(new Dragon(strength, context));
        }
        public void SetEnemyLevelType(EnemyLevelType levelType)
        {
            this.type = levelType;    
        }
        public int GenerateStrength()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            switch (type)
            {
                case EnemyLevelType.LowLevel:
                    strength = random.Next(20,31);
                    break;
                case EnemyLevelType.MiddleLevel:
                    strength = random.Next(31, 46);
                    break;
                case EnemyLevelType.HighLevel:
                    strength = random.Next(46, 60);
                    break;
            }
            return strength;
        }
        public int RandomEnemyIndexGenerator()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            int index = random.Next(enemyList.Count);
            return index;
        }
        public IEnemy GenerateEnemy(EnemyLevelType enemyLevelType)
        {
            SetEnemyLevelType(enemyLevelType);
            int index = RandomEnemyIndexGenerator();
            IEnemy enemy = enemyList[index];
            enemyList.Remove(enemy);
            strength = GenerateStrength();
            enemy.SetStrength(strength);
            return enemy;
        }
    }
}

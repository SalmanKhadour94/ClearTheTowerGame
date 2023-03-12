using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearTheTower
{
    class GameContext
    {
        int levelListIndex;
        public int numberOfLevels = 6;
        List<ILevel> levelList = new List<ILevel>();
        ILevel current_level;
        Player player;
        UserInterfaceHandler userInterfaceHandler;
        RiddleClass riddles;
        EnemyCreator enemyCreator;


        public GameContext(Player player)
        {
            enemyCreator = new EnemyCreator(this);
            levelListIndex = 0;
            levelList.Add(new Level1(this,enemyCreator));
            levelList.Add(new Level2(this,enemyCreator));
            levelList.Add(new Level3(this,enemyCreator));
            levelList.Add(new Level4(this,enemyCreator));
            levelList.Add(new Level5(this,enemyCreator));
            levelList.Add(new Level6(this,enemyCreator));
            this.player = player;
            current_level = levelList[levelListIndex];
            userInterfaceHandler = new UserInterfaceHandler(this);
            riddles = new RiddleClass();
        }
        public int GetLevelListIndex()
        {
            return levelListIndex;
        }
        public UserInterfaceHandler GetUserInterfaceHandler()
        {
            return userInterfaceHandler;
        }
        public Player GetPlayer()
        {
            return player;
        }
        public bool visitTheWitch()
        {
            userInterfaceHandler.showWitchMenu();
            int random_riddleIdx;
            Random random = new Random(Guid.NewGuid().GetHashCode());
            random_riddleIdx = random.Next(0, riddles.GetNumberOfRiddles());
            bool result = riddles.GetRiddle(random_riddleIdx)();
            riddles.GetRiddlesList().Remove(riddles.GetRiddle(random_riddleIdx));
            return result;
        }
        public void fightTheBeast()
        {
            bool result=current_level.fightTheBeast();
            userInterfaceHandler.showFightResults(result);
            if(levelListIndex<numberOfLevels-1)
            {
                if(result==true)
                {
                    levelListIndex++;
                    userInterfaceHandler.showResults(GameResult.LevelUp);
                    current_level=levelList[levelListIndex];
                }
                if(result==false)
                {
                    if(player.GetHP()>0)
                    {
                        userInterfaceHandler.showResults(GameResult.Stay);
                    }
                    else
                    {
                        userInterfaceHandler.showResults(GameResult.Lost);
                    }
                    
                }
            }
            else if(levelListIndex==numberOfLevels-1)
            {
                if (result == true)
                {;
                    userInterfaceHandler.showResults(GameResult.Won);
                }
                if (result == false)
                {
                    if (player.GetHP() > 0)
                    {
                        userInterfaceHandler.showResults(GameResult.Stay);
                    }
                    else
                    {
                        userInterfaceHandler.showResults(GameResult.Lost);
                    }
                }

            }
        }
        public bool visitTheMarket(char option)
        {
            
            switch (option)
            {
                case '1':
                    Potion smallPotion = new Potion(CollectableType.NormalSmallPotion);
                    if (player.GetShillings() > smallPotion.GetPrice())
                    {
                        player.AddToBackpack(smallPotion.GetType());
                        player.decreaseShillings(smallPotion.GetPrice());
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case '2':
                    Potion mediumPotion = new Potion(CollectableType.NormalMediumPotion);
                    if (player.GetShillings() > mediumPotion.GetPrice())
                    {
                        player.AddToBackpack(mediumPotion.GetType());
                        player.decreaseShillings(mediumPotion.GetPrice());
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case '3':
                    Potion largePotion = new Potion(CollectableType.NormalLargePotion);
                    if (player.GetShillings() > largePotion.GetPrice())
                    {
                        player.AddToBackpack(largePotion.GetType());
                        player.decreaseShillings(largePotion.GetPrice());
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case '4':
                    Potion frogAntidotePotion = new Potion(CollectableType.FrogAntidotePotion);
                    if (player.GetShillings() > frogAntidotePotion.GetPrice())
                    {
                        player.AddToBackpack(frogAntidotePotion.GetType());
                        player.decreaseShillings(frogAntidotePotion.GetPrice());
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case '5':
                    Potion warewolfAntidotePotion = new Potion(CollectableType.WarewolfAntidotePotion);
                    if (player.GetShillings() > warewolfAntidotePotion.GetPrice())
                    {
                        player.AddToBackpack(warewolfAntidotePotion.GetType());
                        player.decreaseShillings(warewolfAntidotePotion.GetPrice());
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case '6':
                    Weapon smallWeapon = new Weapon(CollectableType.NormalSmallWeapon);
                    if (player.GetShillings() > smallWeapon.GetPrice())
                    {
                        player.AddToBackpack(smallWeapon.GetType());
                        player.decreaseShillings(smallWeapon.GetPrice());
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case '7':
                    Weapon mediumWeapon = new Weapon(CollectableType.NormalMediumWeapon);
                    if (player.GetShillings() > mediumWeapon.GetPrice())
                    {
                        player.AddToBackpack(mediumWeapon.GetType());
                        player.decreaseShillings(mediumWeapon.GetPrice());
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case '8':
                    Weapon largeWeapon = new Weapon(CollectableType.NormalLargeWeapon);
                    if (player.GetShillings() > largeWeapon.GetPrice())
                    {
                        player.AddToBackpack(largeWeapon.GetType());
                        player.decreaseShillings(largeWeapon.GetPrice());
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case '9':
                    userInterfaceHandler.showTradeMenu();
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    int choice = int.Parse(key.KeyChar.ToString());
                    object[,] backpack = player.GetBackpack();
                    int current_num_of_items = (int)backpack[choice - 1, 1];
                    ICollectable collectable = (ICollectable)backpack[choice - 1, 0];
                    if (current_num_of_items > 0)
                    {
                        player.increaseShillings(collectable.GetPrice());
                        CollectableType type = collectable.GetType();
                        player.TakeFromBackpack(type);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                default:
                    return false;
            }

        }
        public bool openTheBackpack(char option)
        {
            object[,] backpack = player.GetBackpack();
            switch (option)
            {
                case '1':
                    int normal_S_pot = (int)backpack[0, 1];
                    ICollectable normal_S_pot_Coll = (ICollectable)backpack[0, 0];
                    if(normal_S_pot > 0)
                    {
                        player.increaseHP(normal_S_pot_Coll.GetHP());
                        CollectableType type = normal_S_pot_Coll.GetType();
                        player.TakeFromBackpack(type);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case '2':
                    int normal_M_pot = (int)backpack[1, 1];
                    ICollectable normal_M_pot_Coll = (ICollectable)backpack[1, 0];
                    if (normal_M_pot > 0)
                    {
                        player.increaseHP(normal_M_pot_Coll.GetHP());
                        CollectableType type = normal_M_pot_Coll.GetType();
                        player.TakeFromBackpack(type);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case '3':
                    int normal_L_pot = (int)backpack[2, 1];
                    ICollectable normal_L_pot_Coll = (ICollectable)backpack[2, 0];
                    if (normal_L_pot > 0)
                    {
                        player.increaseHP(normal_L_pot_Coll.GetHP());
                        CollectableType type = normal_L_pot_Coll.GetType();
                        player.TakeFromBackpack(type);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case '4':
                    int normal_S_wea = (int)backpack[5, 1];
                    ICollectable normal_S_wea_Coll = (ICollectable)backpack[5, 0];
                    if (normal_S_wea > 0)
                    {
                        player.increaseMP(normal_S_wea_Coll.GetMP());
                        CollectableType type = normal_S_wea_Coll.GetType();
                        player.TakeFromBackpack(type);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case '5':
                    int normal_M_wea = (int)backpack[6, 1];
                    ICollectable normal_M_wea_Coll = (ICollectable)backpack[6, 0];
                    if (normal_M_wea > 0)
                    {
                        player.increaseMP(normal_M_wea_Coll.GetMP());
                        CollectableType type = normal_M_wea_Coll.GetType();
                        player.TakeFromBackpack(type);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case '6':
                    int normal_L_wea = (int)backpack[7, 1];
                    ICollectable normal_L_wea_Coll = (ICollectable)backpack[7, 0];
                    if (normal_L_wea > 0)
                    {
                        player.increaseMP(normal_L_wea_Coll.GetMP());
                        CollectableType type = normal_L_wea_Coll.GetType();
                        player.TakeFromBackpack(type);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                default:
                    return false;
            }
        }
    }
}

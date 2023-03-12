using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearTheTower
{
    class Player
    {
        int shillings=10;
        int healthPoints=100;
        int magicPoints=25;
        object[,] backpack;

        public Player()
        {
            backpack = new object[8, 2]
            {
                {new Potion(CollectableType.NormalSmallPotion),0 },
                {new Potion(CollectableType.NormalMediumPotion),0 },
                {new Potion(CollectableType.NormalLargePotion),0 },
                {new Potion(CollectableType.FrogAntidotePotion),0 },
                {new Potion(CollectableType.WarewolfAntidotePotion),0 },
                {new Weapon(CollectableType.NormalSmallWeapon),0 },
                {new Weapon(CollectableType.NormalMediumWeapon),0 },
                {new Weapon(CollectableType.NormalLargeWeapon),0 },
            };
        }
        public object[,] GetBackpack()
        {
            return backpack;
        }
        public void UpdateBackPack(object[,] newBackpack)
        {
            backpack = newBackpack;
        }
        public bool TakeFromBackpack(CollectableType type)
        {
            switch (type)
            {
                case CollectableType.NormalSmallPotion:
                    int num_of_s_pot = (int)backpack[0, 1];
                    if (num_of_s_pot > 0)
                    {
                        backpack[0, 1] = num_of_s_pot - 1;
                        return true;
                    }
                    return false;
                case CollectableType.NormalMediumPotion:
                    int num_of_m_pot = (int)backpack[1, 1];
                    if (num_of_m_pot > 0)
                    {
                        backpack[1, 1] = num_of_m_pot - 1;
                        return true;
                    }
                    return false;
                case CollectableType.NormalLargePotion:
                    int num_of_l_pot = (int)backpack[2, 1];
                    if (num_of_l_pot > 0)
                    {
                        backpack[2, 1] = num_of_l_pot - 1;
                        return true;
                    }
                    return false;
                case CollectableType.FrogAntidotePotion:
                    int num_of_fr_pot = (int)backpack[3, 1];
                    if (num_of_fr_pot > 0)
                    {
                        backpack[3, 1] = num_of_fr_pot - 1;
                        return true;
                    }
                    return false;
                case CollectableType.WarewolfAntidotePotion:
                    int num_of_wa_pot = (int)backpack[4, 1];
                    if (num_of_wa_pot > 0)
                    {
                        backpack[4, 1] = num_of_wa_pot - 1;
                        return true;
                    }
                    return false;
                case CollectableType.NormalSmallWeapon:
                    int num_of_s_wpn = (int)backpack[5, 1];
                    if (num_of_s_wpn > 0)
                    {
                        backpack[5, 1] = num_of_s_wpn - 1;
                        return true;
                    }
                    return false;
                case CollectableType.NormalMediumWeapon:
                    int num_of_m_wpn = (int)backpack[6, 1];
                    if (num_of_m_wpn > 0)
                    {
                        backpack[6, 1] = num_of_m_wpn - 1;
                        return true;
                    }
                    return false;
                case CollectableType.NormalLargeWeapon:
                    int num_of_l_wpn = (int)backpack[7, 1];
                    if (num_of_l_wpn > 0)
                    {
                        backpack[7, 1] = num_of_l_wpn - 1;
                        return true;
                    }
                    return false;
                default:
                    return false;

            }
        }
        public void AddToBackpack(CollectableType type)
        {
            switch(type)
            {
                case CollectableType.NormalSmallPotion:
                    int num_of_s_pot=(int)backpack[0,1];
                    backpack[0, 1] = num_of_s_pot + 1;
                    break;
                case CollectableType.NormalMediumPotion:
                    int num_of_m_pot = (int)backpack[1, 1];
                    backpack[1, 1] = num_of_m_pot + 1;
                    break;
                case CollectableType.NormalLargePotion:
                    int num_of_l_pot = (int)backpack[2, 1];
                    backpack[2, 1] = num_of_l_pot + 1;
                    break;
                case CollectableType.FrogAntidotePotion:
                    int num_of_fr_pot = (int)backpack[3, 1];
                    backpack[3, 1] = num_of_fr_pot + 1;
                    break;
                case CollectableType.WarewolfAntidotePotion:
                    int num_of_wa_pot = (int)backpack[4, 1];
                    backpack[4, 1] = num_of_wa_pot + 1;
                    break;
                case CollectableType.NormalSmallWeapon:
                    int num_of_s_wpn= (int)backpack[5, 1];
                    backpack[5, 1] = num_of_s_wpn + 1;
                    break;
                case CollectableType.NormalMediumWeapon:
                    int num_of_m_wpn = (int)backpack[6, 1];
                    backpack[6, 1] = num_of_m_wpn + 1;
                    break;
                case CollectableType.NormalLargeWeapon:
                    int num_of_l_wpn = (int)backpack[7, 1];
                    backpack[7, 1] = num_of_l_wpn + 1;
                    break;
                default:
                    break;

            }
        }
        public int CheckBackpack(CollectableType type)
        {
            switch (type)
            {
                case CollectableType.NormalSmallPotion:
                    int num_of_s_pot = (int)backpack[0, 1];
                    return num_of_s_pot;
                case CollectableType.NormalMediumPotion:
                    int num_of_m_pot = (int)backpack[1, 1];
                    return num_of_m_pot;
                case CollectableType.NormalLargePotion:
                    int num_of_l_pot = (int)backpack[2, 1];
                    return num_of_l_pot;
                case CollectableType.FrogAntidotePotion:
                    int num_of_fr_pot = (int)backpack[3, 1];
                    return num_of_fr_pot;
                case CollectableType.WarewolfAntidotePotion:
                    int num_of_wa_pot = (int)backpack[4, 1];
                    return num_of_wa_pot;
                case CollectableType.NormalSmallWeapon:
                    int num_of_s_wpn = (int)backpack[5, 1];
                    return num_of_s_wpn;
                case CollectableType.NormalMediumWeapon:
                    int num_of_m_wpn = (int)backpack[6, 1];
                    return num_of_m_wpn;
                case CollectableType.NormalLargeWeapon:
                    int num_of_l_wpn = (int)backpack[7, 1];
                    return num_of_l_wpn;
                default:
                    return 0;

            }
        }
        public int GetHP()
        {
            return healthPoints;
        }
        public int GetMP()
        {
            return magicPoints;
        }
        public int GetShillings()
        {
            return shillings;
        }
        public void increaseHP(int points)
        {
            healthPoints=healthPoints+points;
        }
        public void decreaseHP(int points)
        {
            healthPoints = healthPoints - points;
        }
        public void increaseMP(int points)
        {
            magicPoints = magicPoints + points;
        }
        public void decreaseMP(int points)
        {
            magicPoints = magicPoints - points;

        }
        public void increaseShillings(int coins)
        {
            shillings = shillings + coins;
        }
        public void decreaseShillings(int coins)
        {
            shillings = shillings - coins;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearTheTower
{
    public enum CollectableType
    {
        NormalSmallPotion,
        NormalMediumPotion,
        NormalLargePotion,
        FrogAntidotePotion,
        WarewolfAntidotePotion,
        NormalSmallWeapon,
        NormalMediumWeapon,
        NormalLargeWeapon,
    }
    interface ICollectable
    {
        CollectableType GetType();
        int GetPrice();
        int GetHP();
        int GetMP();
    }
}

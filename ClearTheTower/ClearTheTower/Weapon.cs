using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearTheTower
{
 
    class Weapon: ICollectable
    {
        CollectableType type;
        int MP;
        int price;
        public Weapon(CollectableType weaponType)
        {
            this.type = weaponType;
            SetMPandPrice();
        }

        public new CollectableType GetType()
        {
            return type;
        }
        public int GetMP()
        {
            return MP;
        }
        public int GetHP()
        {
            return 0;
        }
        public int GetPrice()
        {
            return price;
        }
        private void SetMPandPrice()
        {
            switch (type)
            {
                case CollectableType.NormalSmallWeapon:
                    MP = 10;
                    price = 7;
                    break;
                case CollectableType.NormalMediumWeapon:
                    MP = 20;
                    price = 12;
                    break;
                case CollectableType.NormalLargeWeapon:
                    MP = 40;
                    price = 20;
                    break;
                default:
                    break;
            }

        }
    }
}

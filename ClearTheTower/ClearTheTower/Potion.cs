using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearTheTower
{

    class Potion:ICollectable
    {
        CollectableType type;
        int HP;
        int price;
        public Potion(CollectableType potionType)
        {
            this.type = potionType;
            SetHPandPrice();
        } 

        public new CollectableType GetType()
        {
            return type;
        }
        public int GetHP()
        {
            return HP;
        }
        public int GetMP()
        {
            return 0;
        }
        public int GetPrice()
        {
            return price;
        }
        private void SetHPandPrice()
        {
            switch(type)
            {
                case CollectableType.NormalSmallPotion:
                    HP = 10;
                    price = 8;
                    break;
                case CollectableType.NormalMediumPotion:
                    HP = 20;
                    price = 15;
                    break;
                case CollectableType.NormalLargePotion:
                    HP = 40;
                    price = 27;
                    break;
                case CollectableType.FrogAntidotePotion:
                    HP = 0;
                    price = 30;
                    break;
                case CollectableType.WarewolfAntidotePotion:
                    HP = 0;
                    price = 30;
                    break;
                default:
                    break;
            }

        }

    }
}

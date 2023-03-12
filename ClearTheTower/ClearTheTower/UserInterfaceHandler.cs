using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearTheTower
{
    public enum GameResult
    {
        LevelUp,
        Stay,
        Won,
        Lost
    };
    class UserInterfaceHandler
    {
        GameContext context;
        RiddleClass riddles;
        public UserInterfaceHandler(GameContext context)
        {
            this.context = context;
            
            riddles= new RiddleClass();
        }
        public void showStory()
        {
            Console.WriteLine("                                                            ");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("|              *** SAVE THE TOWER ***                      |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("|  Dear Knight,                                            |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("|  Our Kingdom has been invaded by magical creatures       |");
            Console.WriteLine("|  of bad intensions. They have gained control over        |");
            Console.WriteLine("|  our main defense tower. Each of its floor is guarded    |");
            Console.WriteLine("|  by one of the invadors. To retrieve the tower, you      |");
            Console.WriteLine("|  must defeat them all.                                   |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("|  We will gift you 10 shillings as your journy will       |");
            Console.WriteLine("|  be dangerous. You may buy and sell any weapons or       |");
            Console.WriteLine("|  potions at our local market. You can also get them      |");
            Console.WriteLine("|  from the witch. However, be warned, if you do not       |");
            Console.WriteLine("|  answer her question correctly, she will transform       |");
            Console.WriteLine("|  you into a frog.                                        |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("|  Yours faithfully,                                       |");
            Console.WriteLine("|  King and Queen                                          |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("                                                            ");

        }

        public void showMenu()
        {
            Console.WriteLine("                                                            ");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("|        *** CHOOSE WHAT YOU WISH TO DO KNIGHT ***         |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("| 1. Visit a  witch                                        |");
            Console.WriteLine("| 2. Fight the beast                                       |");
            Console.WriteLine("| 3. Visit the town's market place                         |");
            Console.WriteLine("| 4. Open your backback                                    |");
            Console.WriteLine("| 5. Quit                                                  |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("|      *** You can clear the console with Enter ***        |");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("                                                            ");
        }
        public void showLevel(int level)
        {
            switch (level)
            {
                case 1:
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("|                                                          |");
                    Console.WriteLine("|                   *** LEVEL 1 ***                        |");
                    Console.WriteLine("|                                                          |");
                    Console.WriteLine("------------------------------------------------------------");
                    break;
                case 2:
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("|                                                          |");
                    Console.WriteLine("|                   *** LEVEL 2 ***                        |");
                    Console.WriteLine("|                                                          |");
                    Console.WriteLine("------------------------------------------------------------");
                    break;
                case 3:
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("|                                                          |");
                    Console.WriteLine("|                   *** LEVEL 3 ***                        |");
                    Console.WriteLine("|                                                          |");
                    Console.WriteLine("------------------------------------------------------------");
                    break;
                case 4:
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("|                                                          |");
                    Console.WriteLine("|                   *** LEVEL 4 ***                        |");
                    Console.WriteLine("|                                                          |");
                    Console.WriteLine("------------------------------------------------------------");
                    break;
                case 5:
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("|                                                          |");
                    Console.WriteLine("|                   *** LEVEL 5 ***                        |");
                    Console.WriteLine("|                                                          |");
                    Console.WriteLine("------------------------------------------------------------");
                    break;
                case 6:
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("|                                                          |");
                    Console.WriteLine("|                   *** LEVEL 6 ***                        |");
                    Console.WriteLine("|                                                          |");
                    Console.WriteLine("------------------------------------------------------------");
                    break;
                default:
                    break;


            }
        }
        public void showMarketMenu()
        {
            Console.WriteLine("                                                            ");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("|                  *** MARKET MENU ***                     |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("| Welcome!!! Take a look at what we have to offer          |");
            Console.WriteLine("| or trade your items for money                            |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("|        *** CHOOSE WHAT YOU WISH TO DO KNIGHT ***         |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("|  1. Buy a small health potion for 8 shillings            |");
            Console.WriteLine("|  2. Buy a midium health potion for 15 shillings          |");
            Console.WriteLine("|  3. Buy a big health potion for 27 shillings             |");
            Console.WriteLine("|  4. Buy a frog antidote potion for 30 shillings          |");
            Console.WriteLine("|  5. Buy a warewolf antidote potion for 30 shillings      |");
            Console.WriteLine("|  6. Buy a small weapon for 7 shillings                   |");
            Console.WriteLine("|  7. Buy a midium weapon for 12 shillings                 |");
            Console.WriteLine("|  8. Buy a big weapon for 20 shillings                    |");
            Console.WriteLine("|  9. Sell items from your backback                        |");
            Console.WriteLine("|  0. Exit                                                 |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("|                                                          |");
            Console.Write("|    ");
            Console.Write("* HealthPoints *");
            Console.Write("   * MagicPoints *");
            Console.Write("   * Shillings *");
            Console.WriteLine("    |");
            Console.Write("           ");
            Console.Write(context.GetPlayer().GetHP());
            Console.Write("                 ");
            Console.Write(context.GetPlayer().GetMP());
            Console.Write("              ");
            Console.Write(context.GetPlayer().GetShillings());
            Console.WriteLine("           ");
            Console.WriteLine("|                                                          |");

        }
        public void showWitchMenu()
        {
            Console.WriteLine("                                                            ");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("|                  *** WHITCH'S HUT ***                    |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("| Welcome my Knight! Answer my riddle correctly and        |");
            Console.WriteLine("| I will reward you with potions and weapons... however    |");
            Console.WriteLine("| if you can not anser my question correctly I will        |");
            Console.WriteLine("| turn you into a frog! Then, only a very rare magic       |");
            Console.WriteLine("| potion can save you!                                     |");
            Console.WriteLine("|                                                          |");

        }
        public void showTrollMenu(Troll troll)
        {
            Console.WriteLine("                                                            ");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("|                *** YOU MET A TROLL ***                   |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("| I eat knights like you for breakfast! You don't stand    |");
            Console.WriteLine("| a chance!                                                |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("|                     *** FIGHT ***                        |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("| If you win, you will get "+ (int)Math.Floor(0.5 * troll.GetStrength())+" shillings                    |");
            Console.WriteLine("| If you lose, you will lose " + (int)Math.Floor(0.5 * troll.GetStrength()) + " health points              |");
            Console.WriteLine("|                                                          |");
        }
        public void showSnakeMenu(Snake snake)
        {
            Console.WriteLine("                                                            ");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("|                *** YOU MET A SNAKE ***                   |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("| Sssss... I will not leave this tower willingly!          |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("|                     *** FIGHT ***                        |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("| If you win, you can make a health potion out of the      |");
            Console.WriteLine("| snake's venom depending on the snake's strength. Check   |");
            Console.WriteLine("| your backpack for the reward!                            |");
            Console.WriteLine("| If you lose, you will lose " + (int)Math.Floor(0.5 * snake.GetStrength()) + " health points              |");
            Console.WriteLine("|                                                          |");
        }
        public void showDragonMenu(Dragon dragon)
        {
            Console.WriteLine("                                                            ");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("|                *** YOU MET A DRAGON ***                  |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("| The fire I breathe will anihilate you in a second!       |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("|                     *** FIGHT ***                        |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("| If you win, you can make a weapon out of the dragon's    |");
            Console.WriteLine("| skales depending on the snake's strength. Check your     |");
            Console.WriteLine("| backpack for the reward!                                 |");
            Console.WriteLine("| If you lose, you will lose " + (int)Math.Floor(0.75 * dragon.GetStrength()) + " health points              |");
            Console.WriteLine("|                                                          |");
        }
        public void showOgreMenu(Ogre ogre)
        {
            Console.WriteLine("                                                            ");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("|                *** YOU MET AN OGRE ***                   |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("| AAAAAAAAGGHHHHHHHHRRRRRR! I KILL YOU!                    |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("|                     *** FIGHT ***                        |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("| If you win, you can make a frog antidote potion out of   |");
            Console.WriteLine("| the ogre's snots. Check your backpack for the reward!    |");
            Console.WriteLine("| If you lose, you will lose " + ogre.GetStrength() + " health points              |");
            Console.WriteLine("|                                                          |");
        }
        public void showVampireMenu(Vampire vampire)
        {
            Console.WriteLine("                                                            ");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("|              *** YOU MET A VAMPIRE ***                   |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("| Welcome my beutiful Knight...                            |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("|          *** CHOOSE WHAT YOU WANT TO DO  ***             |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("| 1. Try to seduce the vampire                             |");
            Console.WriteLine("| 2. Fight the vampire                                     |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("| If you manage to seduce, you will get " + (2 * vampire.GetStrength()) + " shillings       |");
            Console.WriteLine("| If you can not seduce, you will lose " + vampire.GetStrength() + " health points    |");
            Console.WriteLine("| If you fight and win, you will get " + (int)Math.Floor(0.5 * vampire.GetStrength()) + " shillings          |");
            Console.WriteLine("| If you fight and lose, you will lose " + (int)Math.Floor(0.5 * vampire.GetStrength()) + " health points    |");
            Console.WriteLine("|                                                          |");
        }
        public void showWarewolfMenu(Warewolf warewolf)
        {
            Console.WriteLine("                                                            ");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("|              *** YOU MET A WAREWOLF ***                  |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("| I once was a knight like you but I angered the witch     |");
            Console.WriteLine("| and for that I have to suffer... AND I WILL MAKE YOU     |");
            Console.WriteLine("| YOU SUFFER TOO! You will not get out of this alive!      |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("|          *** CHOOSE WHAT YOU WANT TO DO  ***             |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("| 1. Offer the warewolf antidote potion                    |");
            Console.WriteLine("| 2. Fight the warewolf                                    |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("| If you heal the warewolf, you will get " + 2 * warewolf.GetStrength() + " shillings      |");
            Console.WriteLine("| If you offer the warewolf antidote potion but it is      |");
            Console.WriteLine("| not in your possesion, you will anger the warewolf so    |");
            Console.WriteLine("| much that you will lose all your health points and the   |");
            Console.WriteLine("| game in result                                           |");
            Console.WriteLine("| If you fight and win, you will get " + (int)Math.Floor(0.5 * warewolf.GetStrength()) + " shillings          |");
            Console.WriteLine("| If you fight and lose, you will lose " + (int)Math.Floor(0.5 * warewolf.GetStrength()) + " health points    |");
            Console.WriteLine("|                                                          |");
        }
        public void showFightResults(bool result)
        {
            if(result==true)
            {
                Console.WriteLine("|                                                          |");
                Console.WriteLine("|                  *** YOU WON ***                         |");
                Console.WriteLine("|                                                          |");
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("                                                            ");
            }
            else
            {
                Console.WriteLine("|                                                          |");
                Console.WriteLine("|                  *** YOU LOST ***                        |");
                Console.WriteLine("|                                                          |");
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("                                                            ");
                if(context.GetPlayer().GetHP() == 0)
                {
                    showResults(GameResult.Lost);
                }
            }
        }
        public bool HandleInput()
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.KeyChar == '1')
            {
                if (riddles.GetNumberOfRiddles() > 0)
                {
                    bool result = context.visitTheWitch();

                    if (result == false)
                    {
                        Console.WriteLine("|                                                          |");
                        Console.WriteLine("|            *** POOF! YOU BECAME A FROG ***               |");
                        Console.WriteLine("|          Let's check if you have an antidote...          |");
                        Console.WriteLine("|        If you have one, the game will continue           |");
                        Console.WriteLine("|                                                          |");
                        if (context.GetPlayer().CheckBackpack(CollectableType.FrogAntidotePotion) > 0)
                        {
                            context.GetPlayer().TakeFromBackpack(CollectableType.FrogAntidotePotion);
                            Console.WriteLine("|                                                          |");
                            Console.WriteLine("|                  *** ANTIDOTE USED ***                   |");
                            Console.WriteLine("|                                                          |");
                            Console.WriteLine("------------------------------------------------------------");
                            Console.WriteLine("                                                            ");
                        }
                        else
                        {
                            Console.WriteLine("|                                                          |");
                            Console.WriteLine("|                 *** ANTIDOTE NOT FOUND ***               |");
                            Console.WriteLine("|                                                          |");
                            Console.WriteLine("------------------------------------------------------------");
                            Console.WriteLine("                                                            ");
                            showResults(GameResult.Lost);

                        }

                    }
                    else
                    {
                        Random rand = new Random(Guid.NewGuid().GetHashCode());
                        int random_potion = rand.Next(0, 5);
                        context.GetPlayer().AddToBackpack((CollectableType)random_potion);
                        
                        Console.WriteLine("|                                                          |");
                        Console.WriteLine("|                *** CONGRATULATIONS! ***                  |");
                        Console.WriteLine("|               You will be rewarded with                  |");
                        Console.Write("                      ");
                        Console.WriteLine((CollectableType)random_potion+ "               ");
                        Console.WriteLine("|                                                          |");
                        Console.WriteLine("------------------------------------------------------------");
                        Console.WriteLine("                                                            ");
                    }
                }
                else
                {
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("|                                                          |");
                    Console.WriteLine("| I don't have any more riddles for you my Knight          |");
                    Console.WriteLine("|                                                          |");
                    Console.WriteLine("------------------------------------------------------------");
                }

                return true;
            }
            else if (key.KeyChar == '2')
            {
                context.fightTheBeast();
                return true;
            }
            else if (key.KeyChar == '3')
            {
                showMarketMenu();
                ConsoleKeyInfo choice = Console.ReadKey(true);
                bool result=context.visitTheMarket(choice.KeyChar);
                if(result==true)
                {
                    Console.WriteLine("|                                                          |");
                    Console.WriteLine("|               *** OPERATION SUCCESFULL ***               |");
                    Console.WriteLine("|                                                          |");
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("                                                            ");
                }
                else
                {
                    Console.WriteLine("|                                                          |");
                    Console.WriteLine("|             *** OPERATION NOT SUCCESFULL ***             |");
                    Console.WriteLine("|                                                          |");
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("                                                            ");
                }
                  
                return true;
            }
            else if (key.KeyChar == '4')
            {
                showBackpack();
                ConsoleKeyInfo choice = Console.ReadKey(true);
                bool result = context.openTheBackpack(choice.KeyChar);
                if (result == true)
                {
                    Console.WriteLine("|                                                          |");
                    Console.WriteLine("|               *** OPERATION SUCCESFULL ***               |");
                    Console.WriteLine("|                                                          |");
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("                                                            ");
                }
                else
                {
                    Console.WriteLine("|                                                          |");
                    Console.WriteLine("|             *** OPERATION NOT SUCCESFULL ***             |");
                    Console.WriteLine("|                                                          |");
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("                                                            ");
                }
                return true;
            }
            else if (key.KeyChar == '5')
            {
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("|                                                          |");
                Console.WriteLine("|                    *** GOODBYE ***                       |");
                Console.WriteLine("|                                                          |");
                Console.WriteLine("------------------------------------------------------------");
                System.Environment.Exit(1);
                return true;
            }
            else if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                showMenu();
                return true;
            }
            else
            {
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("|                                                          |");
                Console.WriteLine("|        ***  Incorrect input, please try again  ***       |");
                Console.WriteLine("|                                                          |");
                Console.WriteLine("------------------------------------------------------------");
                return true;
            }
        }
        public void showBackpack()
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("|                 *** YOUR BACKPACK  ***                   |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("|  Small Health Potions: "+context.GetPlayer().CheckBackpack(CollectableType.NormalSmallPotion)+ "                                 |");
            Console.WriteLine("|  Medium Health Potions: " + context.GetPlayer().CheckBackpack(CollectableType.NormalMediumPotion) + "                                |");
            Console.WriteLine("|  Large Health Potions: " + context.GetPlayer().CheckBackpack(CollectableType.NormalLargePotion) + "                                 |");
            Console.WriteLine("|  Frog Antidote Potions: " + context.GetPlayer().CheckBackpack(CollectableType.FrogAntidotePotion) + "                                |");
            Console.WriteLine("|  Warewolf Antidote Potions: " + context.GetPlayer().CheckBackpack(CollectableType.WarewolfAntidotePotion) + "                            |");
            Console.WriteLine("|  Small Magic Weapons: " + context.GetPlayer().CheckBackpack(CollectableType.NormalSmallWeapon) + "                                  |");
            Console.WriteLine("|  Medium Magic Weapons: " + context.GetPlayer().CheckBackpack(CollectableType.NormalMediumWeapon) + "                                 |");
            Console.WriteLine("|  Large Magic Weapons: " + context.GetPlayer().CheckBackpack(CollectableType.NormalLargeWeapon) + "                                  |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("|                                                          |");
            Console.Write("|    ");
            Console.Write("* HealthPoints *");
            Console.Write("   * MagicPoints *");
            Console.Write("   * Shillings *");
            Console.WriteLine("    |");
            Console.Write(" s          ");
            Console.Write(context.GetPlayer().GetHP());
            Console.Write("                 ");
            Console.Write(context.GetPlayer().GetMP());
            Console.Write("              ");
            Console.Write(context.GetPlayer().GetShillings());
            Console.WriteLine("           ");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("|         *** CHOOSE WHAT YOU WISH TO USE ***              |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("|  1. Drink a small health potion for 10 HP                |");
            Console.WriteLine("|  2. Drink a medium health potion for 20 HP               |");
            Console.WriteLine("|  3. Drink a big health potion for 40 HP                  |");
            Console.WriteLine("|  4. Use a small weapon for 10 MP                         |");
            Console.WriteLine("|  5. Use a medium weapon for 20 MP                        |");
            Console.WriteLine("|  6. Use a big weapon for 40 MP                           |");
            Console.WriteLine("|  7. Exit                                                 |");
            Console.WriteLine("|                                                          |");
            
        }
        public void showTradeMenu()
        {
            Console.WriteLine("|                                                          |");
            Console.WriteLine("|          *** CHOOSE WHAT YOU WISH TO SELL ***            |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("|  1. Sell a small health potion for 8 shillings           |");
            Console.WriteLine("|  2. Sell a midium health potion for 15 shillings         |");
            Console.WriteLine("|  3. Sell a big health potion for 27 shillings            |");
            Console.WriteLine("|  4. Sell a frog antidote potion for 30 shillings         |");
            Console.WriteLine("|  5. Sell a warewolf antidote potion for 30 shillings     |");
            Console.WriteLine("|  6. Sell a small weapon for 7 shillings                  |");
            Console.WriteLine("|  7. Sell a medium weapon for 12 shillings                |");
            Console.WriteLine("|  8. Sell a big weapon for 20 shillings                   |");
            Console.WriteLine("|  9. Exit                                                 |");
            Console.WriteLine("|                                                          |");
        }
        public void showResults(GameResult result)
        {
            switch (result)
            {
                case GameResult.LevelUp:
                    Console.WriteLine("                                                            ");
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("|                                                          |");
                    Console.WriteLine("|                      LEVEL UP                            |");
                    Console.WriteLine("|                                                          |");
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("                                                            ");
                    break;
                case GameResult.Stay:
                    Console.WriteLine("                                                            ");
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("|                                                          |");
                    Console.WriteLine("|             YOU NEED TO DEFEAT THE BEAST                 |");
                    Console.WriteLine("|                      TO LEVEL UP                         |");
                    Console.WriteLine("|                                                          |");
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("                                                            ");
                    break;
                case GameResult.Won:
                    Console.WriteLine("                                                            ");
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("|                                                          |");
                    Console.WriteLine("|               *** You won the game ***                   |");
                    Console.WriteLine("|                   CONGRATULATIONS!!!                     |");
                    Console.WriteLine("|                                                          |");
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("                                                            ");
                    System.Environment.Exit(1);
                    break;
                case GameResult.Lost:
                    Console.WriteLine("                                                            ");
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("|                                                          |");
                    Console.WriteLine("|               *** You lost the game ***                  |");
                    Console.WriteLine("|                 BETTER LUCK NEXT TIME                    |");
                    Console.WriteLine("|                                                          |");
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("                                                            ");
                    System.Environment.Exit(1);
                    break;
                default:
                    break;
            }
        }


    }
}

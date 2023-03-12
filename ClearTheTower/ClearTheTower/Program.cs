using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearTheTower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();   
            GameContext context = new GameContext(player);
            UserInterfaceHandler userInterfaceHandler = new UserInterfaceHandler(context);
            userInterfaceHandler.showStory();
            userInterfaceHandler.showMenu();
            userInterfaceHandler.showLevel(context.GetLevelListIndex() + 1);

            while (true)
            {
                bool done = userInterfaceHandler.HandleInput();
                while (done == false) ;
                userInterfaceHandler.showLevel(context.GetLevelListIndex() + 1);
            }
        }
    }
}

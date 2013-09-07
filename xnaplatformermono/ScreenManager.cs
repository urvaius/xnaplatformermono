using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace xnaplatformermono
{
    public class ScreenManager
    {
        /// <summary>
        /// Storing the GameScreens
        /// </summary>
        Dictionary<string, GameScreen> screens = new Dictionary<string, GameScreen>();

        Stack<GameScreen> ScreenStack = new Stack<GameScreen>();


    }
}

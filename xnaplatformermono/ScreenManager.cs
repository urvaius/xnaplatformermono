using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
namespace xnaplatformermono
{
    public class ScreenManager
    {

        #region Variables
        /// <summary>
        /// creating custom conetnt manager
        /// </summary>
        ContentManager content;
        GameScreen currentScreen;
        GameScreen newScreen;
        /// <summary>
        /// screenmanager instance
        /// </summary>
        private static ScreenManager instance;
        /// <summary>
        /// Screen Stack
        /// </summary>
        Stack<GameScreen> ScreenStack = new Stack<GameScreen>();
        /// <summary>
        /// screens width and height
        /// </summary>
        Vector2 dimensions;
        #endregion

        #region properties
        public static ScreenManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new ScreenManager();
                return instance;
            }
        }
        public Vector2 Dimensions
        {
            get { return dimensions; }
            set { dimensions = value; }
        }


        #endregion

        #region Main Methods
        public void AddScreen(GameScreen screen)
        {
            newScreen = screen;
            ScreenStack.Push(screen);
            currentScreen.UnloadContent();
            currentScreen = newScreen;
            currentScreen.LoadContent(content);
        }
        public void Initialize()
        {
            currentScreen = new SplashScreen();

        }
        public void LoadContent(ContentManager Content)
        {
            content = new ContentManager(Content.ServiceProvider, "Content");

        }
        public void Update(GameTime gameTime)
        {
            currentScreen.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            currentScreen.Draw(spriteBatch);


        }
        #endregion
    }
}

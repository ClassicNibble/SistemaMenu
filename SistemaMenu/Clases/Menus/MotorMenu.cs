using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

namespace Clases
{
    public class MotorMenu
    {
        MenuPaused menuPaused = new MenuPaused();

        MainMenuGAme mainmenu = new MainMenuGAme();

        public MotorMenu()
        {

        }
        public void LoadContent(Microsoft.Xna.Framework.Content.ContentManager Content, Microsoft.Xna.Framework.GraphicsDeviceManager _graphics)
        {
            menuPaused.LoadContent(Content, _graphics);
            mainmenu.LoadContent(Content, _graphics);
        }
        public void Draw(SpriteBatch _spriteBatch)
        {
            switch (Globals.CurrentGameState)
            {
                case Globals.GameStates.MainMenu:
                    mainmenu.Draw(_spriteBatch);
                    break;
                ///IN GAME
                case Globals.GameStates.Paused:

                    menuPaused.Draw(_spriteBatch);


                    break;
                case Globals.GameStates.InGame:
                    /// TRAZADO

                    break;
            }
        }
        public void Update()
        {
            MouseState mouse = Mouse.GetState();

            switch (Globals.CurrentGameState)
            {
                case Globals.GameStates.MainMenu:
                    mainmenu.PressButtonPlay(mouse);
                    break;

                case Globals.GameStates.Exit:
                    System.Environment.Exit(0);
                    break;
                case Globals.GameStates.Paused:
                    menuPaused.PressButtonPaused(mouse);

                    break;
                case Globals.GameStates.InGame:

                    if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                    {
                        if (Globals.PausekeyPress == false)
                        {
                            Globals.PausekeyPress = true;
                            Globals.CurrentGameState = Globals.GameStates.Paused;

                        }
                    }
                    else
                    {
                        Globals.PausekeyPress = false;
                    }

                    break;


            }
        }

    }
}
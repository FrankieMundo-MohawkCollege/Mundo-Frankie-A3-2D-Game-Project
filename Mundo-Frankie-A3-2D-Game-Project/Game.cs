// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
       Color LightBlue = new Color(173, 216, 230);
       Platform platform = new Platform();
       Player player = new Player();
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
        
        Window.SetTitle("Mundo-Frankie-A3-2D-Game-Project");
        Window.SetSize(800, 600);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(LightBlue);
            platform.Update();
            player.Update();

        }
    }

}

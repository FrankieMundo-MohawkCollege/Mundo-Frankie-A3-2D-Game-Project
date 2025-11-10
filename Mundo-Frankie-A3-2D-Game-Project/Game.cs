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
        Color DarkGreen = new Color(0, 128, 0);
        Platform platform = new Platform();
        Player player = new Player();

        Potion[] potions =
        {
            new Potion (new Vector2 (100, 100), new Vector2 (20, 20), true),
            new Potion (new Vector2 (200, 150), new Vector2 (20, 20), true),
            new Potion (new Vector2 (300, 200), new Vector2 (20, 20), true),
            new Potion (new Vector2 (400, 250), new Vector2 (20, 20), true),
            new Potion (new Vector2 (500, 168), new Vector2 (20, 20), true),
            new Potion (new Vector2 (600, 241), new Vector2 (20, 20), true),
            new Potion (new Vector2 (700, 136), new Vector2 (20, 20), true),
            new Potion (new Vector2 (150, 190), new Vector2 (20, 20), true),
            new Potion (new Vector2 (250, 158), new Vector2 (20, 20), true),
            new Potion (new Vector2 (350, 204), new Vector2 (20, 20), true)
        };


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
            int score = player.currentScore;
            if (score < 10)
            {

                Window.ClearBackground(LightBlue);
                platform.Update();
                player.Update(potions);
                for (int i = 0; i < potions.Length; i++)
                {
                    potions[i].Update();
                }
                Text.Color = Color.White;
                Text.Size = 15;
                Text.Draw($"Score : {score}/10", new Vector2(10, 10));
            }
            else
            {
                Window.ClearBackground(DarkGreen);
                Text.Color = Color.White;
                Text.Size = 30;
                Text.Draw("Congrats! You win!", new Vector2(100, 250));

            }
        }
    }

}

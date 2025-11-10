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
        Bullet[] bullets = new Bullet[100];
        int BulletIndex = 0;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.Title = "Bullet Spawning";
            Window.SetSize(800, 600);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.White);


        }
    }

      void SpawnBullet()
        {
            if (Input.IsMouseButtonPressed(MouseInput.))
            {
                Bullet newBullet = new Bullet();


                Vector2 centerScreen = Window.Size / 2.0f;

                bullet.position = centerScreen;

                Vector2 centerToMouse = Input.GetMousePosition - centerScreen;
                bullet.velocity = Vector2.Normalize(centerToMouse);

                bullets[BulletIndex] = Bullet;
                BulletIndex++;
                if (BulletIndex >= Bullets.Length);
                {
                    BulletIndex = 0;


                }
        }
    }
  }

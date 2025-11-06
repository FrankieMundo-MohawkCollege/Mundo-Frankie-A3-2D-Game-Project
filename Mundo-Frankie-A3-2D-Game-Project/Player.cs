using System;
using System.Numerics;

namespace MohawkGame2D
{
    public class Player 
    {
        Vector2 position;
        Vector2 velocity = new Vector2 (0, 0);
        float gravity = 0.6f;
        bool isOnGround = false;
        public void Setup()
        {

        }

        public void Update()
        {
            Physics();
            DrawPlayer();
        }

        void Physics()
        {
            velocity.Y += gravity;
            position.X += velocity.X;

            if (position.Y > 300)
            {
                position.Y = 300;
                velocity.Y = 0;
                isOnGround = true;
            }
            else
            {
                isOnGround = false;
            }

            if (isOnGround)
            {
                velocity.Y = -10;
            }
        }      

        void DrawPlayer()
        {
            Draw.FillColor = Color.Red;
            Draw.Rectangle(position.X, position.Y, 50, 50);
        }

    }
}


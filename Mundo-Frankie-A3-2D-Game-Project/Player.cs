using Raylib_cs;
using System;
using System.Numerics;

namespace MohawkGame2D
{   
    public class Player 
    {
        Color DarkPurple = new Color(40, 45, 90);
        Vector2 position;
        Vector2 velocity = new Vector2 (0, 0);
        Vector2 size = new Vector2 (50, 50);
        float gravity = 200f;
        bool isOnGround;
        public int currentScore = 0;
        public void Setup()
        {

        }

        public void Update(Potion[] potions)
        {
            SimulateGravity();
            Physics(potions);
            inputs();
            DrawPlayer();
            
        }

        void Physics(Potion[] potions)
        {
            float playerTop = position.Y;
            float playerBottom = position.Y + size.Y;
            float playerLeft = position.X;
            float playerRight = position.X + size.X;

            
            if (playerTop <= 0)
            {
                position.Y = 0;
                velocity.Y = 0f;
            }

            if (playerBottom >= 300)
            {
                position.Y = 300 - size.Y;
                velocity.Y = 0f;
                isOnGround = true;
            }

            if (playerLeft <= 0)
                position.X = 0;

            if (playerRight >= 800)
                position.X = 800 - size.X;

            for (int i = 0; i < potions .Length; i++)
            {
                Potion potion = potions[i];
                float potionTop = potion.position.Y;
                float potionBottom = potion.position.Y + potion.size.Y;
                float potionLeft = potion.position.X;
                float potionRight = potion.position.X + potion.size.X;

                bool isColliding = playerRight > potionLeft &&
                                   playerLeft < potionRight &&
                                   playerBottom > potionTop &&
                                   playerTop < potionBottom;
                if (isColliding && potion.alive)
                {
                    potion.alive = false;
                    currentScore += 1;

                }
            }
        }      

        void DrawPlayer()
        {
            Draw.FillColor = DarkPurple;
            Draw.Rectangle (position, size);
        }

        void inputs()
        {
            if (Input.IsKeyboardKeyPressed(KeyboardInput.Space) && isOnGround)
            {
                velocity.Y -= 100;
            }

            if (Input.IsKeyboardKeyDown(KeyboardInput.A))
            {
                position.X -= 2;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.D))
            {
                position.X += 2;
            }
        }

        public void SimulateGravity()
        {
            
            velocity.Y += gravity * Time.DeltaTime;
            
            position.Y += velocity.Y * Time.DeltaTime;
        }

       
    }
}


using System;
using System.Numerics;

namespace MohawkGame2D
{
    public class Potion
    {
        Color Purple = new Color(128, 0, 128);
        public Vector2 position;
        public Vector2 size;
        public bool alive;

        public Potion(Vector2 position, Vector2 size, bool alive)
        {
            this.position = position;
            this.size = size;
            this.alive = alive;
        }

        public void Setup()
        {
            

        }

        public void Update()
        {
            if (alive)
            {
                DrawPotionHitbox();
            }
        }

        void DrawPotionHitbox()
        {
            Draw.FillColor = Purple;
            Draw.Rectangle(position, size);
        }

       
    }


}
using System;

namespace MohawkGame2D
{
    public class Platform
    {
        public void Setup()
        {
            
        }

        public void Update()
        {
            Draw.FillColor = Color.Green;
            Draw.LineSize = 10;
            Draw.Rectangle(800, 600, 400, 100);

        }
    }

}

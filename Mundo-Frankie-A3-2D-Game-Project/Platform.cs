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
            Draw.LineSize = 0;
            Draw.Rectangle(100, 300, 200, 50);
        }
    }

}

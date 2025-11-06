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
            Draw.Rectangle(0, Window.Height / 2, Window.Width, Window.Height / 2);
            

        }
    }

}

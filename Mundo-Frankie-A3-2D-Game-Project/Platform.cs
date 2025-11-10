using System;

namespace MohawkGame2D
{
    public class Platform
    {
        Color GrassGreen = new Color(65, 152, 10);
        public void Setup()
        {
            
        }

        public void Update()
        {
            Draw.FillColor = GrassGreen;
            Draw.LineSize = 0;
            Draw.Rectangle(0, Window.Height / 2, Window.Width, Window.Height / 2);
            

        }
    }

}

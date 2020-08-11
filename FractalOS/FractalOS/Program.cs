using System;
using OpenTK;
using OpenTK.Graphics;
namespace FractalOS
{
    internal class Program
    {
        public static void Main()
        {
            OperatingSystem Orange = new OperatingSystem(new GameWindow(800, 600, GraphicsMode.Default, "FractalOS", GameWindowFlags.Default));
        }
    }
}
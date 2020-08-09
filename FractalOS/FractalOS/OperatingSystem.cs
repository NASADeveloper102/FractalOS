using System;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace FractalOS
{
    public class OperatingSystem
    {
        public GameWindow window;
        public OperatingSystem(GameWindow screen)
        {
            this.window = screen;

            this.window.Load += Load;
            this.window.RenderFrame += Render;
            this.window.UpdateFrame += Update;
            this.window.Closing += Close;

            this.window.Run(1/60);
        }
        public void Load(object sender, EventArgs e)
        {
            GL.ClearColor(0.0f, 0.0f, 0.0f, 1.0f);
        }
        public void Render(object sender, FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Flush();


            window.SwapBuffers();
        }
        public void Update(object sender, FrameEventArgs e)
        {
            
        }
        public void Close(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}

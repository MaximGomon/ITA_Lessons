using System;

namespace Decorator
{
    public interface IPainter
    {
        void Draw();
    }

    public class BoardPainter : IPainter
    {
        public virtual void Draw()
        {
            Console.WriteLine("Draw on board!");
        }
    }
}
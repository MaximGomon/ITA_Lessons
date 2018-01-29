using System;

namespace Decorator
{
    public interface IPaintDecorator : IPainter
    {
    }

    public class WallDecorator : IPaintDecorator
    {
        private readonly IPainter _painter;

        public WallDecorator(IPainter painter)
        {
            _painter = painter;
        }

        public void Draw()
        {
            _painter.Draw();
            Console.WriteLine("Draw on wall");
        }
    }

    public class CartoonDecorator : IPaintDecorator
    {
        private readonly IPainter _painter;

        public CartoonDecorator(IPainter painter)
        {
            _painter = painter;
        }

        public void Draw()
        {
            _painter.Draw();
            Console.WriteLine("Draw Cartoon");
        }
    }

}
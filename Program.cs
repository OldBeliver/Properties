using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            int positionX = 7;
            int positionY = 5;

            Player player = new Player(positionX, positionY);
            Renderer renderer = new Renderer();

            renderer.DrawPlayer(player);
        }
    }

    class Player
    {        
        public Player(int axisX, int axisY)
        {
            Icon = '♂';
            PositionX = axisX;
            PositionY = axisY;
        }       

        public char Icon { get; private set; }
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }
    }

    class Renderer
    {
        public void DrawPlayer(Player player)
        {
            Console.SetCursorPosition(player.PositionX, player.PositionX);
            Console.WriteLine(player.Icon);
        }
    }
}

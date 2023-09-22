using System;

namespace WarriorProject
{
    public class Position
    {
        public int x;
        public int y;

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void ToConsole()
        {
            Console.WriteLine("(" + x + "," + y + ")");
        }
        
    }

    public class Warrior
    {
        private string name;
        private Position position;

        public Warrior(string name, Position position)
        {
            this.name = name;
            this.position = position;

        }

        public void MoveHorizontal(int dist)
        {
            position.x += dist;
        }

        public void MoveVertical(int dist)
        {
            position.y += dist;
        }

        public void ToConsole()
        {
            Console.WriteLine($"{name}, position ({position.x},{position.y})");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Position position = new Position(2, -1);
            position.ToConsole();
            Warrior warrior = new Warrior("Peter the Iron Man", position);
            warrior.ToConsole();
            warrior.MoveHorizontal(3);
            warrior.MoveVertical(-2);
            warrior.ToConsole();
        }
    }
}

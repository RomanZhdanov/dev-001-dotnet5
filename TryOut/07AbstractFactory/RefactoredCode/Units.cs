using System;
using System.Drawing;

namespace TryOut.AbstractFactory.RefactoredCode
{

    public enum RaceType
    {
        Human,
        Zerg,
        Protos
    }

    public enum UnitType
    {
        Infantry,
        Rangers,
        LightVehicle,
        Tank,
        Helicopter
    }

    public interface IInfantry
    {
        int Armor { get; set; }
        int HP { get; set; }
        int Attack { get; set; }
        Player Player { get; }
        Point Point { get; set; }
        void Draw();
    }

    public class InfantryUnit : IUnitPrototype, IInfantry
    {
        public int Armor { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public Player Player { get; private set; }
        public Point Point { get; set; }

        public InfantryUnit(Player player) => Player = player;

        public void Draw()
        {
            var format = string.Format("{0} {1} {2}", Player.Race, Point.X, Point.Y);
            Console.WriteLine(format);
        }

        public IUnitPrototype Clone()
        {
            return (IUnitPrototype)MemberwiseClone();
        }
    }
}

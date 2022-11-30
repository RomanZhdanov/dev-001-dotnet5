using System.Collections.Generic;

namespace TryOut.AbstractFactory.RefactoredCode
{
    public class UnitsFactory
    {
        private readonly Dictionary<RaceType, InfantryUnit> _infantryUnits;

        public UnitsFactory(Player player)
        {
            _infantryUnits = GetInfantryUnits(player);
        }

        public InfantryUnit CreateInfantry(RaceType race)
        {
            return (InfantryUnit)_infantryUnits[race].Clone();
        }

        private Dictionary<RaceType, InfantryUnit> GetInfantryUnits(Player player)
        {
            return new Dictionary<RaceType, InfantryUnit>
            {
                {
                    RaceType.Human,
                    new InfantryUnit(player) { Armor = 10, HP = 20, Attack = 5 }
                },
                {
                    RaceType.Zerg,
                    new InfantryUnit(player) { Armor = 5, HP = 25, Attack = 10 }
                },
                {
                    RaceType.Protos,
                    new InfantryUnit(player) { Armor = 25, HP = 5, Attack = 15 }
                }

            };
        }
    }
}

namespace TryOut.AbstractFactory.RefactoredCode
{
    public class Player
    {
        private readonly UnitsFactory _unitsFactory;

        public RaceType Race { get; set; }

        public Player()
        {
            _unitsFactory = new UnitsFactory(this);
        }

        public IInfantry CreateInfantry()
        {
            return _unitsFactory.CreateInfantry(Race);
        }        
    }
}

namespace NavalBattle
{
    public class Coords
    {
        private string coordsLocation;

        private bool hasBeenAttacked = false;

        public Coords(string aCoordsLocation)
        {
            this.coordsLocation = aCoordsLocation;
        }

        public string CoordsLocation
        {
            get
            {
                return this.coordsLocation;
            }
        }

        public bool HasBeenAttacked
        {
            get
            {
                return this.hasBeenAttacked;
            }
        }

    
        public bool CoordsEquals(Coords coord)
        {
            return (this.CoordsLocation == coord.coordsLocation);
        }

        public void ChangeCoordState()
        {
            this.hasBeenAttacked = true;
        }
    }
}
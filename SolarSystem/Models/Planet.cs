namespace SolarSystem.Models
{
    /// <summary>
    /// This class is used for base model of a planet,
    /// used to identify planets trough the application
    /// </summary>
    public class Planet
    {
        #region fields
        private int _id;
        private string _planetName;
        #endregion

        #region Properties
        public string Name
        {
            get { return _planetName; }
            set { _planetName = value; }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        #endregion
    }
}

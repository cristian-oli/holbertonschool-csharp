using System;

namespace Enemies
{
    /// <sumary>
    /// This class creates zombies
    /// </sumary>
    class Zombie 
    {
        /// <sumary> Property for the name of the zombie </sumary>
        public string Name { get {return name;} set { name = value;} }

        /// <sumary> Private member for the health of the zombie </sumary>
        public int health;

        /// <sumary> Private member for the health of the zombie </sumary>
        public string name = "(No name)";

        /// <sumary> Class constructor for the zombie's health by default </sumary>
        public Zombie()
        {
            this.health = 0;
        }

        /// <sumary> Class constructor for the health zombie </sumary>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            else
                health = value;
        }

        /// <sumary> Public method that return the Zombie's health </sumary>
        public int GetHealth()
        {
            return health;
        }

        ///<sumary> Override the ToString method to so that prints a string representation for the Class Zombie  </sumary>
        public override string ToString() => String.Format("Zombie Name: {0} / Total Health: {1}", name, health);
    }
}

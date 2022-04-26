using System;

namespace Enemies
{
    /// <sumary>
    /// This class creates zombies
    /// </sumary>
    class Zombie 
    {        
        /// <sumary> Private member for the health of the zombie </sumary>
        public int health;

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
    }
}

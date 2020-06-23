using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace DZ_12
{
    public class Tank
    {
        public string _theNamesOfTheTank; 
        public int _levelTankAmmunition;
        public int _amorLevel;
        public int _levelManeuverability; 


        public Tank(string theNamesOfTheTank)
        {
            Random rand = new Random();

            _theNamesOfTheTank = theNamesOfTheTank;
            _levelTankAmmunition = rand.Next(0, 100);
            _amorLevel = rand.Next(0, 100);
            _levelManeuverability = rand.Next(0, 100);
        }
    }
}

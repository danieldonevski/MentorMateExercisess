using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesReflection
{
    class Character
    {
        private string charName;
        private string charRace;
        private string charClass;

        public string  CharName
        {
            get { return charName; }
            set { charName = value; }
        }
        
        public string CharRace
        {
            get { return charRace; }
            set { charRace = value; }
        }
        
        public string CharClass
        {
            get { return charClass; }
            set { charClass = value; }
        }

        public int AttackPower()
        {
            return 150;
        }
        public int Health()
        {
            return 150;
        }
        public void Atack()
        {

        }
    }
}

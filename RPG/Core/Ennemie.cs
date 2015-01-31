using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG.Core
{
    class Ennemie:Entity,ISoignable,IAttaquable
    {
        public void Soigner(int PvGagner)
        {
            _pvActuel = _pvActuel + PvGagner;
        }


        public void PrendreDegats(int DegatsSubis)
        {
            _pvActuel = _pvActuel - DegatsSubis;
        }

        public Ennemie(int pvMax, int manaMax, int force, int intel, int armure, string nom, int level, int degatPhysique, int degatMagique)
            : base(pvMax, manaMax, force, intel, armure, nom, level)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG.Core
{
    class Joueur:Entity,IAttaquable,ISoignable
    {
        private int _degatPhysique;
        private int _degatMagique;

        public int DegatPhysique
        {
            get
            {
                return _degatPhysique;
            }
        }

        public int DegatMagique
        {
            get
            {
                return _degatMagique;
            }
        }


        public void Soigner(int PvGagner)
        {
            _pvActuel = _pvActuel + PvGagner;
        }

        public void PrendreDegats(int DegatsSubis)
        {
            _pvActuel = _pvActuel - DegatsSubis;
        }

        public Joueur(int pvMax, int manaMax, int force, int intel, int armure, string nom, int level, int degatPhysique, int degatMagique)
            : base(pvMax, manaMax, force, intel, armure, nom, level)
        {
            _degatMagique = degatMagique;
            _degatPhysique = degatPhysique;
        }
    }
}

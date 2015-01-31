using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG.Core
{
    class Joueur:Entity
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

    }
}

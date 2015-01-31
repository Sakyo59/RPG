using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK.Graphics.OpenGL;

namespace RPG.Core.Items
{
    public enum TypeItemUtilisable
    {
        soin,
        degat
    }
    class ItemUtilisable : Item
    {
        

        private TypeItemUtilisable _typeItemUtilisable;
        private int _pv;
        private int _degat;

        public TypeItemUtilisable TypeItemUtilisable
        {
            get { return _typeItemUtilisable; }
        }

        public int Pv
        {
            get { return _pv;}
        }

        public int Degat
        {
            get { return _degat; }
        }

        public ItemUtilisable (string nom, string description, int pv, int degat, TypeItemUtilisable typeItemUtilisable) : base(nom, description)
        {
            _pv = pv;
            _degat = degat;
            _typeItemUtilisable = typeItemUtilisable;
        }

    }
}

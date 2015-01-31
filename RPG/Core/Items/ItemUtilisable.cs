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
        private int _effect;

        public TypeItemUtilisable TypeItemUtilisable
        {
            get { return _typeItemUtilisable; }
        }

        public int Effect
        {
            get { return _effect;}
        }

        public ItemUtilisable (string nom, string description, int effect, TypeItemUtilisable typeItemUtilisable) : base(nom, description)
        {
            _effect = effect;
            _typeItemUtilisable = typeItemUtilisable;
        }

    }
}

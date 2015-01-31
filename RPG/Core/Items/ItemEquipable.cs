using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using OpenTK.Graphics.OpenGL;

namespace RPG.Core.Items
{
    class ItemEquipable : Item
    {
        public enum Type
        {
            Tete,
            Torse,
            Jamble,
            Pied,
            Arme1Main,
            Arme2Main,
            Bouclier
        }

        private int _pv;
        private int _mana;
        private int _degatPhysique;
        private int _degatMagique;
        private int _armure;

        public ItemEquipable(string nom, string description, int pv, int mana, int degatPhysique, int degatMagique, int armure) : base(nom, description)
        {
            _pv = pv;
            _mana = mana;
            _degatPhysique = degatPhysique;
            _degatMagique = degatMagique;
            _armure = armure;
        }
    }
}

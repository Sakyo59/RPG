using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG.Core
{
    class Entity
    {
        protected int _pvMax;
        protected int _pvActuel;
        protected int _manaMax;
        protected int _manaActuel;
        protected int _force;
        protected int _intel;
        protected int _armure;
        protected string _nom;
        protected int _level;

        public int PvMax
        {
            get
            {
                return _pvMax;
            }
        }
        public int PvActuel
        {
            get
            {
                return _pvActuel;
            }
        }
        public int ManaMax
        {
            get
            {
                return _manaMax;
            }
        }
        public int ManaActuel
        {
            get
            {
                return _manaActuel;
            }
        }
        public int Force
        {
            get
            {
                return _force;
            }

        }
        public int Intel
        {
            get
            {
                return _intel;
            }
        }
        public int Armure
        {
            get
            {
                return _armure;
            }
        }
        public string Nom
        {
            get
            {
                return _nom;
            }
        }
        public int Level
        {
            get
            {
                return _level;
            }
        }
        public Entity(int pvMax,int manaMax,int force,int intel,int armure,string nom,int level)
        {
            _pvMax = pvMax;
            _pvActuel = pvMax;
            _manaMax = manaMax;
            _manaActuel = manaMax;
            _force = force;
            _intel = intel;
            _armure = armure;
            _nom = nom;
            _level = level;
        }
    }
}

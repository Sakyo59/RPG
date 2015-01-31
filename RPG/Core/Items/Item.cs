namespace RPG.Core.Items
{
    class Item
    {
        protected string _nom;
        protected string _description;

        public string Nom
        {
            get { return _nom; }
        }

        public string Description
        {
            get { return _description; }
        }

        protected Item(string nom, string description)
        {
            _nom = nom;
            _description = description;
        }
    }
}

namespace iterator
{
    public class Item
    {
        private string _name;
        private readonly int _id;

        public Item(int id, string name)
        {
            this._id = id;
            this._name = name;
        }

        public int Id => _id;
        public string Name => _name;
    }
}
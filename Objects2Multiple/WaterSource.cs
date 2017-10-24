namespace Objects2Multiple
{
    class WaterSource
    {
        public string Name { get; }
        public int Supply { get; }

        public WaterSource(string name, int supply)
        {
            this.Name = name;
            this.Supply = supply;
        }
    }
}

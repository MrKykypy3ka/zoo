namespace zoo
{
    abstract class essence
    {
        protected double x;
        protected double y;
        protected double z;
        protected string name;
        protected int mood;
        public essence(string name, double x, double y, double z)
        {
            this.name = name;
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public string Name { get { return name; } }
        public int Mood { set { mood = value; } get { return mood; } }
    }
}

using System;

namespace zoo
{
    abstract class human : essence
    {
        protected human(string name, double x, double y, double z) : base(name, x, y, z)
        {
        }
        public void feed(animal active)
        {
            active.Hunger += 20;
            active.Mood += 10;
        }
        public void iron(animal active)
        {
            active.Mood += 10;
        }
    }
}

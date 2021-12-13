using System;

namespace zoo
{
    class player : human
    {
        public player(string name, double x, double y, double z) : base(name, x, y, z)
        {
            this.name = name;
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void photo(aviary exhibit)
        {
            Console.WriteLine($"{exhibit} сфотографирован");
        }
        public void photo(animal exhibit)
        {
            Console.WriteLine($"Животное - {exhibit.Kind}, сфотографировано"); ;
        }
        public void talk(Iinteraction companion)
        {
            companion.talk();
        }
        public void getInfo(Iinfo thing)
        {
            thing.getInfo();
        }
    }
}

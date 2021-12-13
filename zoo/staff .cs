using System;

namespace zoo
{
    class staff : human, Iinteraction
    {
        string position;
        public staff(string name, string position, double x, double y, double z) : base(name, x, y, z)
        {
            this.name = name;
            this.position = position;
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public string clean(aviary dirty)
        {
            return $"Вольер {dirty.Number} чистый";
        }
        public string wash(animal dirty)
        {
            dirty.Mood += 20;
            return $"{dirty.Name} помыли";
        }
        public string treat(animal sick)
        {
            sick.Health = 100;
            return $"{sick.Name} Здоровый";
        }
        public void talk()
        {
            Console.WriteLine($"Начас диалог с {name}");
        }
        public void getInfo()
        {
            Console.WriteLine($"{position} {name}");
        }
    }
}

using System;

namespace zoo
{
    abstract class animal : essence, Iinteraction, Iinfo
    {
        protected string kind;
        protected bool predator;
        protected int age;
        protected int hunger;
        protected int health;
        protected int speed;
        public animal(string name, string kind, bool predator, int age, int hunger, int mood, double x, double y, double z) : base(name, x, y, z)
        {
            this.name = name;
            this.kind = kind;
            this.predator = predator;
            this.age = age;
            this.hunger = 100;
            this.mood = 50;
            health = 100;
            speed = 0;
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public string Kind { get { return kind; } }
        public bool Predator { get { return predator; } }
        public int Age { set { age = value; } get { return age; } }
        public int Hunger { set { hunger = value; } get { return hunger; } }
        public int Health { set { health = value; } get { return health; } }
        public int Speed { set { speed = value; } get { return speed; } }

        public string attack(animal enemy)
        {
            mood -= 10;
            enemy.Mood -= 10;
            enemy.Health -= 10;
            return $"{name} атаковал {enemy.Name}";
        }
        public void eat()
        {
            hunger += 50;
        }
        public void sleep()
        {
            mood += 50;
            health += 10;
        }
        public string scream()
        {
            return $"{name} кричит";
        }
        public void talk()
        {
            Console.WriteLine($"Начас диалог с {name}");
        }
        public void getInfo()
        {
            Console.WriteLine($"{Kind} по имени {name}. Его возраст {age}.");
        }
    }
}

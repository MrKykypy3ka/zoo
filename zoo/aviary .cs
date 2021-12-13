using System;

namespace zoo
{
    class aviary : Iinfo
    {
        private int number;
        private string type;
        private int cleanliness_level;
        public aviary(int number, string type)
        {
            this.number = number;
            this.type = type;
            cleanliness_level = 100;
        }

        public int Number { get { return number; } }
        public string Type { set { type = value; } get { return type; } }
        public int Cleanliness_level { set { cleanliness_level = value; } get { return cleanliness_level; } }

        public void getInfo()
        {
            Console.WriteLine($"Вольер № {number}, типа {type}");
        }
    }
}

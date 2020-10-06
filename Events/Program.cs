using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var tower = new ClockTower();
            var Hugues = new Person("Hugues", tower);

            tower.ChimeFivePM();

            tower.ChimeSixPM();
        }
    }

    public class Person
    {
        private string _name;
        private ClockTower _tower;

        public Person(string name, ClockTower tower)
        {
            _name = name;
            _tower = tower;

            _tower.chime += (object sender, ClockTowerEventArgs args) =>
            {
                Console.WriteLine("{0} Heard the clock chime", _name);

                switch (args.Time)
                {
                    case 6:
                        Console.WriteLine("{0} This person is going up", _name);
                        break;
                    case 17:
                        Console.WriteLine("{0} This person is going home", _name);
                        break;
                }
            };
        }
    }

    public class ClockTowerEventArgs : EventArgs
    {
        public int Time { get; set; }
    }


    public delegate void ChimeEventHandler(object sender, ClockTowerEventArgs args);
    public class ClockTower
    {
        public event ChimeEventHandler chime;

        public void ChimeFivePM()
        {
            chime(this, new ClockTowerEventArgs { Time = 17});
        }

        public void ChimeSixPM()
        {
            chime(this, new ClockTowerEventArgs { Time = 6});
        }
    }
}

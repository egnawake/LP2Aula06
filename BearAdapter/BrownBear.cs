using System;

namespace BearAdapter
{
    public class BrownBear : IBear
    {
        public bool Hibernating { get; set; }

        public void Roar()
        {
            if (Hibernating)
            {
                Console.WriteLine("Brown bear is asleep");
                return;
            }
            Console.WriteLine("Grrrraaaah!");
        }

        public void LookAt(object objectToLookAt)
        {
            if (Hibernating)
            {
                Console.WriteLine("Brown bear is asleep");
                return;
            }
            Console.WriteLine("Brown bear looks at "
                + objectToLookAt.ToString());
        }

        public void GoTowards(object objectToWalkTowards)
        {
            if (Hibernating)
            {
                Console.WriteLine("Brown bear is asleep");
                return;
            }
            Console.WriteLine("Brown bear moves towards "
                + objectToWalkTowards.ToString());
        }

        public bool TryEat(object objectToEat)
        {
            if (Hibernating)
            {
                Console.WriteLine("Brown bear is asleep");
                return false;
            }
            Console.WriteLine("Brown bear ate some "
                + objectToEat.ToString());
            return true;
        }
    }
}

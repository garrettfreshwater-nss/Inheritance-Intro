using System;

namespace InheritanceIntro
{
    public class Vehicle // vehicle clas that will be inherited
    {
        public string MainColor { get; set; }

        public int MainOccupancy { get; set; }
        //method
        public virtual void Drive() // VIRTUAL gives permission to the child to change implementation
        {
            Console.WriteLine("Vroom!");
        }
    }

}
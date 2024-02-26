using System;

namespace PR1._Save_the_ocean
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Xp { get; set; }
        public abstract string InfoPerson();
    }
}

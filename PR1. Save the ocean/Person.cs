﻿using System;

namespace PR1._Save_the_ocean
{
    public abstract class Person
    {
        public string Name { get; set; } //Nombre 
        public int Xp { get; set; } //Experiencia
        public abstract string InfoPerson();
    }
}

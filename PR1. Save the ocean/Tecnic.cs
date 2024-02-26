using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1._Save_the_ocean
{
    public class Tecnic : Person
    {
        public Tecnic(string name, int xp)
        {
            Name = name;
            Xp = xp;
        }

        public override string InfoPerson()
        {
            return $"Hola, {Name}! El 112 ha rebut una trucada d’avís d’un exemplar a rescatar. \r\nLes dades que ens han donat són les següents:\r\n";
        }
    }
}

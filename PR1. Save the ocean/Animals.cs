using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1._Save_the_ocean
{
    public abstract class Animals
    {
        public int RedemptionNumber { get; set; }
        public string DateOfRescue { get; set; }
        public string SpeciesToResue { get; set; }
        public int DegreeOfAffect { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public string SuperFamily {  get; set; }
        public int Weight { get; set; }
        public abstract string InfoDegreeOfAffect();
        public abstract string DescriptionOfAffect();
        public abstract string InfoRescat();
        public abstract string InfoFitxa();
        public abstract double InfoLocationNewDegreeOfAffect();
        public abstract double InfoCRAMNewDegreeOfAffect();
    }
}

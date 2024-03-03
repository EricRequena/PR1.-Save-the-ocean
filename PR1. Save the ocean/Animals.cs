using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1._Save_the_ocean
{
    public abstract class Animals //Classe principal animales
    {
        public int RedemptionNumber { get; set; } //Numero de Rescate
        public string DateOfRescue { get; set; } //Fecha de Rescate
        public string SpeciesToResue { get; set; } //Specie a Rescatar
        public int DegreeOfAffect { get; set; } //Grado de Affectacion 
        public string Location { get; set; } //Localidad
        public string Name { get; set; } //Nombre
        public string SuperFamily {  get; set; } //Familia
        public int Weight { get; set; } //Peso
        public double DegreeOfAffectLaboratory { get; set; } //Grado de Afectacion Lab
        public double DegreeOfAffectCRAM { get; set; } //Grado de Afectacion CRAM

        public abstract string InfoDegreeOfAffect();
        public abstract string DescriptionOfAffect();
        public abstract string InfoRescat();
        public abstract string InfoFitxa();
        public abstract double InfoLocationNewDegreeOfAffect();
        public abstract double InfoCRAMNewDegreeOfAffect();
        public abstract string InfoFinalLaboratory();
        public abstract string InfoFinalCRAM();
    }
}

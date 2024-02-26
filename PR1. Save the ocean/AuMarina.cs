using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1._Save_the_ocean
{
    public class AuMarina : Animals
    {
        public AuMarina(int redemptionNumber, string dateOfRescue, string speciesToResue, int degreeOfAffect, string location, string name, int weight)
        {
            RedemptionNumber = redemptionNumber;
            DateOfRescue = dateOfRescue;
            SpeciesToResue = speciesToResue;
            DegreeOfAffect = degreeOfAffect;
            Location = location;
            Name = name;
            SuperFamily = "Au Marina";
            Weight = weight;
            
   
        }

        public override string DescriptionOfAffect()
        {
            return $"{Name} té un grau d’afectació (GA) del {DegreeOfAffect}%. Vols curar-lo aquí (1) o traslladar-lo al centre (2)?";
        }

        public override string InfoDegreeOfAffect()
        {
            throw new NotImplementedException();
        }
        public override string InfoRescat()
        {
            return $"+-------------------------------------------------------------+\r\n| RESCAT |\r\n+-------------------------------------------------------------+\r\n| # Rescat | Data rescat | Espècie        | GA | Localització |\r\n+-------------------------------------------------------------+\r\n| {RedemptionNumber.ToString("000")} | {DateOfRescue} | {SuperFamily}   | {DegreeOfAffect.ToString("00")} | {Location} |\r\n+-------------------------------------------------------------+;";
        }

        public override string InfoFitxa()
        {
            return $"+-------------------------------------------------------------+\r\n|                       FITXA                                 |\r\n+-------------------------------------------------------------+\r\n| # Nom | Superfamília | Espècie        | Pes aproximat       |\r\n+-------------------------------------------------------------+\r\n| {Name} | {SuperFamily}       | {SpeciesToResue} | {Weight}            |\r\n+-------------------------------------------------------------+";
        }

        public override double InfoLocationNewDegreeOfAffect()
        {
            return DegreeOfAffect - (DegreeOfAffect * DegreeOfAffect + 5);
        }

        public override double InfoCRAMNewDegreeOfAffect()
        {
            return DegreeOfAffect - (DegreeOfAffect * DegreeOfAffect + 0);
        }

    }
}

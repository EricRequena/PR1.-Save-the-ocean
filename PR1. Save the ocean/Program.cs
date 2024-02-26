using PR1._Save_the_ocean;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace oop
{
    public class SaveTheOcean
    {
        public static void Main()
        {
            int option = 0;
            string name;
            int num = Random(0, 2);
            string Species;
            
            Console.WriteLine("Save the ocean!\nQuè vols fer?\n1. Jugar!\n2. Sortir");
            option = Rang(option, 1, 2);

            TortugaMarina TortugaVerde = new TortugaMarina(Random(0, 1000), "11/03/2024", "Tortuga Verde", Random(1, 99), "Santa Coloma de Gamanet", "Tina", 45);
            Cetaci DofíLlistat = new Cetaci(Random(0, 1000), "11/02/2024", "Dofi Llistat", Random(1, 99), "Gavá", "Felix", 225);
            AuMarina Gaviota = new AuMarina(Random(0, 1000), "13/02/24", "Au Marina", Random(1, 99), "Cadaqués", "Richar", 15);

            if (option == 1)
            {

                option = 0;
                Console.WriteLine("Perfecte! Què vols ser?\n\n1. Tècnic (45 XP)\n2. Veterinari (80XP)");
                option = Rang(option, 1, 2);
                Console.WriteLine("Genial! I el teu nom?");

                name = Console.ReadLine();
                if (option == 1)
                {
                    Tecnic Player = new Tecnic(name, 45);
                    Console.WriteLine(Player.InfoPerson());
                }
                if (option == 2)
                {
                    Veterinari Player = new Veterinari(name, 80);
                    Console.WriteLine(Player.InfoPerson());
                }
                Especie specieSelector = (Especie)num;

                string speciesInfoRescue = "";
                string speciesInfoFicha = "";
                double speciesGDLab = 0;
                double speciesGDCRAM = 0;
                string speciesInfoDegree = "";
                switch (specieSelector)
                {
                    case Especie.TortugaVerde:
                        speciesInfoRescue = TortugaVerde.InfoRescat();
                        speciesInfoFicha = TortugaVerde.InfoFitxa();
                        speciesGDLab = TortugaVerde.InfoLocationNewDegreeOfAffect();
                        speciesGDCRAM = TortugaVerde.InfoCRAMNewDegreeOfAffect();
                        speciesInfoDegree = TortugaVerde.DescriptionOfAffect();
                        break;
                    case Especie.DofíLlistat:
                        speciesInfoRescue = DofíLlistat.InfoRescat();
                        speciesInfoFicha = DofíLlistat.InfoFitxa();
                        speciesGDLab = DofíLlistat.InfoLocationNewDegreeOfAffect();
                        speciesGDCRAM = DofíLlistat.InfoCRAMNewDegreeOfAffect();
                        speciesInfoDegree = DofíLlistat.DescriptionOfAffect();
                        break;
                    case Especie.Gaviota:
                        speciesInfoRescue = Gaviota.InfoRescat();
                        speciesInfoFicha = Gaviota.InfoFitxa();
                        speciesGDLab = Gaviota.InfoLocationNewDegreeOfAffect();
                        speciesGDCRAM = Gaviota.InfoCRAMNewDegreeOfAffect();
                        speciesInfoDegree = Gaviota.DescriptionOfAffect();
                        break;
                }
                Console.WriteLine(speciesInfoRescue);
                Console.WriteLine("Aquí tens la seva fitxa, per a més informació:");
                Console.WriteLine(speciesInfoFicha);
                Console.WriteLine(speciesInfoDegree);
                option = 0;
                option = Rang(option, 1, 2);
                if (option == 1)
                {
                    if (speciesGDLab < 5)
                    {
                        Console.WriteLine("El tractament aplicat ha reduït el GA fins al 2%. L’exemplar està recuperat i pot tornar al seu hàbitat. La teva experiència ha augmentat en +50XP.");
                    }
                    else
                    {
                        Console.WriteLine("El tractament aplicat ha reduït el GA fins al 20%. No ha estat prou efectiu i cal traslladar l’exemplar al centre. La teva experiència s’ha reduït en -20XP.");
                    }
                }
                else if (option == 2)
                {
                    if (speciesGDCRAM < 5)
                    {
                        Console.WriteLine("El tractament aplicat ha reduït el GA fins al 2%. L’exemplar està recuperat i pot tornar al seu hàbitat. La teva experiència ha augmentat en +50XP.");
                    }
                    else
                    {
                        Console.WriteLine("El tractament aplicat ha reduït el GA fins al 20%. No ha estat prou efectiu i cal traslladar l’exemplar al centre. La teva experiència s’ha reduït en -20XP.");
                    }
                }

                Console.WriteLine("Fins el proper rescat!");
            }

            
        }

        public static int Rang(int number, int minValue, int maxValue)
        {
            do
            {
                number = Convert.ToInt32(Console.ReadLine());
            } while (number < minValue || number > maxValue);
            return number;
        }

        public static int Random(int lessValue, int maxValue)
        {
            Random value = new Random();
            return value.Next(lessValue, maxValue);
        }

        enum Especie
        {
            TortugaVerde,
            DofíLlistat,
            Gaviota
        };
    }
}
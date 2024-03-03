using PR1._Save_the_ocean;
using System;

namespace oop
{
    public class SaveTheOcean
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Cyan; /*Inicio Programa*/
            Console.WriteLine("╔═════════════════════════════╗");/*Titulo Principal*/
            Console.WriteLine("║ Save the ocean!             ║");
            Console.WriteLine("║ Què vols fer?               ║");
            Console.WriteLine("║  1. Jugar!                  ║");
            Console.WriteLine("║  2. Sortir                  ║");
            Console.WriteLine("╚═════════════════════════════╝");
            Console.ResetColor();

            Console.WriteLine();
            int option = Rang(0, 1, 2); /*Metodo Escoger Numero*/
            TortugaMarina TortugaVerde = new TortugaMarina(Random(0, 1000), "11/03/2024", "Tortuga Verde", Random(1, 99), "Santa Coloma de Gamanet", "Tina", 45); /*Insertar Dadas*/
            Cetaci DofíLlistat = new Cetaci(Random(0, 1000), "11/02/2024", "Dofi Llistat", Random(1, 99), "Gavá", "Felix", 225);
            AuMarina Gaviota = new AuMarina(Random(0, 1000), "13/02/24", "Au Marina", Random(1, 99), "Cadaqués", "Richar", 15);
            do /*Espacio Para continuar*/
            {
                Console.WriteLine("\n¡Presiona la tecla de espacio para continuar!");
            } while ((Console.ReadKey().Key != ConsoleKey.Spacebar));
            Console.Clear();
            if (option == 1) /*Si el usuario escoge jugar*/
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Perfecte! Què vols ser?\n\n1. Tècnic (45 XP)\n2. Veterinari (80XP)");
                Console.WriteLine("__________________________________________________________________");
                Console.ResetColor();
                option = Rang(0, 1, 2); /*Metodo Escoger Numero*/
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Genial! I el teu nom?"); 
                Console.WriteLine("_____________________");
                Console.ResetColor();
                string name = Console.ReadLine();/*Introducir Nombre*/
                do /*Espacio para continuar*/
                {
                    Console.WriteLine("\n¡Presiona la tecla de espacio para continuar!");
                } while ((Console.ReadKey().Key != ConsoleKey.Spacebar));
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                if (option == 1) /*Informacion Tecnico*/
                {
                    Tecnic Player = new Tecnic(name, 45);
                    Console.WriteLine(Player.InfoPerson());
                }
                else if (option == 2) /*Informacion Veterinario*/
                {
                    Veterinari Player = new Veterinari(name, 80);
                    Console.WriteLine(Player.InfoPerson());
                }
                Console.ForegroundColor = ConsoleColor.Magenta;

                Especie specieSelector = (Especie)Random(0, 3); /*Seleccion especie random*/

                string speciesInfoRescue = ""; /*Tabla de Rescate*/
                string speciesInfoFicha = ""; /*Tabla de Información*/
                string speciesInfoDegree = ""; /*Informacion del GA*/
                string speciesOfRescuteNewDegreeLab = ""; /*Info en caso de lboratorio*/
                string speciesOfRescuteNewDegreeCRAM = ""; /*Info en caso de CRAM*/

                switch (specieSelector) /*Switch Espcie*/
                {
                    //Se añade la info de los metodos de cada especie
                    case Especie.TortugaVerde:
                        speciesInfoRescue = TortugaVerde.InfoRescat();
                        speciesInfoFicha = TortugaVerde.InfoFitxa();
                        speciesInfoDegree = TortugaVerde.DescriptionOfAffect();
                        speciesOfRescuteNewDegreeLab = TortugaVerde.InfoFinalLaboratory();
                        speciesOfRescuteNewDegreeCRAM = TortugaVerde.InfoFinalCRAM();
                        break;
                    case Especie.DofíLlistat:
                        speciesInfoRescue = DofíLlistat.InfoRescat();
                        speciesInfoFicha = DofíLlistat.InfoFitxa();
                        speciesInfoDegree = DofíLlistat.DescriptionOfAffect();
                        speciesOfRescuteNewDegreeLab = DofíLlistat.InfoFinalLaboratory();
                        speciesOfRescuteNewDegreeCRAM = DofíLlistat.InfoFinalCRAM();
                        break;
                    case Especie.Gaviota:
                        speciesInfoRescue = Gaviota.InfoRescat();
                        speciesInfoFicha = Gaviota.InfoFitxa();
                        speciesInfoDegree = Gaviota.DescriptionOfAffect();
                        speciesOfRescuteNewDegreeLab = Gaviota.InfoFinalLaboratory();
                        speciesOfRescuteNewDegreeCRAM = DofíLlistat.InfoFinalCRAM();
                        break;
                }

                Console.WriteLine(speciesInfoRescue); /*Tabla Global*/

                
                Console.WriteLine("───────────────────────────────");
                Console.WriteLine("Aquí tens la seva fitxa, per a més informació:"); /*Ficha*/
                Console.WriteLine(speciesInfoFicha);
                Console.WriteLine(speciesInfoDegree);
                

                Console.WriteLine("───────────────────────────────");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Escull una opció:"); //Escoge opcion de donde quieres hacer el tractamiento
                Console.WriteLine("1. Tractament amb GDLab");
                Console.WriteLine("2. Tractament amb GDCRAM");
                Console.ResetColor();
                option = Rang(0, 1, 2); //Metodo rango
                Console.ForegroundColor = ConsoleColor.Cyan;
                if (option == 1) //Condicional depende de donde se traslade 
                {
                    Console.WriteLine(speciesOfRescuteNewDegreeLab); //Cond Laboratorio
                }
                else if (option == 2)
                {
                    Console.WriteLine(speciesOfRescuteNewDegreeCRAM); //Cond CRAM
                }

                
                Console.WriteLine("Fins el proper rescat!"); //Mensaje Final
                Console.ResetColor();
            }
        }

        public static int Rang(int number, int minValue, int maxValue) //Encargado de seleccionar rango
        {
            do
            {
                number = Convert.ToInt32(Console.ReadLine());
            } while (number < minValue || number > maxValue);
            return number;
        }

        public static int Random(int lessValue, int maxValue) //Encargado de seleccioar numero random
        {
            Random value = new Random();
            return value.Next(lessValue, maxValue);
        }

        enum Especie //Enum especies Random Tortuga = 0, Dolfi = 1, Gaviota = 2
        {
            TortugaVerde,
            DofíLlistat,
            Gaviota
        };
    }
}

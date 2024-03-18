using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            bool abandonar = false;

            do
            {
                Console.WriteLine("Bienvenidos al Zoologico virtual");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("0. Abandonar");
                Console.WriteLine("1. Visitar al Leon");
                Console.WriteLine("2. Visitar al Elefante");
                Console.WriteLine("3. Visitar a la Jirafa");
                Console.WriteLine("4. Visitar al tigre");
                Console.WriteLine("5. Visitar al Mono");
                Console.WriteLine("6. Visitar al Oso");
                Console.WriteLine("7. Visitar al Cocodrilo");
                Console.WriteLine("8. Visitar a la Serpiente");
                Console.WriteLine("9. Visitar al Pinguino");
                Console.WriteLine("10. Visitar al Lobo");
                Console.WriteLine("11. Visitar a la Cebra");
                Console.WriteLine("12. Visitar al rinoceronte");
                Console.WriteLine("13. Visitar al Panda");
                Console.WriteLine("14. Visitar al Pavo Real");
                Console.WriteLine("15. Visitar a la Tortuga");
                Console.Write("Orientador: ¿Que deseas hacer?");
                int opcion = int.Parse(Console.ReadLine());

                Console.WriteLine("-----------------------------------------------------------");

                switch (opcion)
                {

                    case 0: abandonar = true; break;
                    case 1: visitarLeon(); break;
                    case 2: visitarElefante(); break;
                    case 3: visitarJirafa(); break;
                    case 4: visitarTigre(); break;
                    case 5: visitarMono(); break;
                    case 6: visitarOso(); break;
                    case 7: visitarCocodrilo(); break;
                    case 8: visitarSerpiente(); break;
                    case 9: visitarPinguino(); break;
                    case 10: visitarLobo(); break;
                    case 11: visitarCebra(); break;
                    case 12: visitarRinoceronte(); break;
                    case 13: visitarPanda(); break;
                    case 14: visitarPavoReal(); break;
                    case 15: visitarTortuga(); break;
                    default: Console.WriteLine("La opcion no está dentro de los parametros"); break;


                }
                Console.ReadKey();
                Console.Clear();

            } while (!abandonar);

        }

        public static void visitarLeon()
        {
            Leon leon = new Leon("Milles", "Macho");
            Console.WriteLine("En la jaula esta {0} ", leon);
            leon.alimentar();
            leon.ruido();
        }

        public static void visitarElefante()
        {
            Elefante elefante = new Elefante("Carl", "Macho");
            Console.WriteLine("En la jaula esta {0} ", elefante);
            elefante.alimentar();
            elefante.ruido();
        }

        public static void visitarJirafa()
        {
            Jirafa jirafa = new Jirafa("Mila", "Hembra");
            Console.WriteLine("En la jaula esta {0} ", jirafa);
            jirafa.alimentar();
            jirafa.ruido();
        }

        public static void visitarTigre()
        {
            Tigre tigre=new Tigre("Leonard","Macho");
            Console.WriteLine("En la jaula esta {0} ", tigre);
            tigre.alimentar();
            tigre.ruido();
        }

        public static void visitarMono()
        {
            Mono mono = new Mono("Jules", "Hembra");
            Console.WriteLine("En la jaula esta {0} ", mono);
            mono.alimentar();
            mono.ruido();
        }

        public static void visitarOso()
        {
            Oso oso = new Oso ("Canela", "Macho");
            Console.WriteLine("En la jaula esta {0} ", oso);
            oso.alimentar();
            oso.ruido();
        }

        public static void visitarCocodrilo()
        {
        Cocodrilo cocodrilo=new Cocodrilo("Carl", "Macho");
            Console.WriteLine("En la jaula esta {0} ", cocodrilo);
            cocodrilo.alimentar();
            cocodrilo.ruido();
        }

        public static void visitarSerpiente()
        {
            Serpiente serpiente = new Serpiente("Iris", "Hembra");
            Console.WriteLine("En la jaula esta {0} ", serpiente);
            serpiente.alimentar();
            serpiente.ruido();
        }

        public static void visitarPinguino()
        {
        Pinguino pinguino= new Pinguino("Jack","Macho");
            Console.WriteLine("En la jaula esta {0} ", pinguino);
            pinguino.alimentar();
            pinguino.ruido();
        }

        public static void visitarLobo()
        {
            Lobo lobo= new Lobo("Jacobs", "Macho");
            Console.WriteLine("En la jaula esta {0} ", lobo);
            lobo.alimentar();
            lobo.ruido();
        }

        public static void visitarCebra()
        {
            Cebra cebra = new Cebra("Susie", "Hembra");
            Console.WriteLine("En la jaula esta {0} ", cebra);
            cebra.alimentar();
            cebra.ruido();
        }

        public static void visitarRinoceronte()
        {
        Rinoceronte rinoceronte = new Rinoceronte("Rudolf", "Macho");
            Console.WriteLine("En la jaula esta {0} ", rinoceronte);
            rinoceronte.alimentar();
            rinoceronte.ruido();
        }

        public static void visitarPanda()
        {
            Panda panda= new Panda("Bepo","Macho");
            Console.WriteLine("En la jaula esta {0} ", panda);
            panda.alimentar();
            panda.ruido();
        }
        public static void visitarPavoReal()
        {
            PavoReal pavoReal = new PavoReal("Elena", "Hembra");
            Console.WriteLine("En la jaula esta {0} ", pavoReal);
            pavoReal.alimentar();
            pavoReal.ruido();
        }
        public static void visitarTortuga()
        {
         Tortuga tortuga = new Tortuga("Luffy", "Macho");
            Console.WriteLine("En la jaula esta {0} ", tortuga);
            tortuga.alimentar();
            tortuga.ruido();
        
        }

    }
}

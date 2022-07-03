using System;

namespace SimuladorDeMarianoNavarroV0._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora12, minutos, segundos, hora24;
            char turno;

            Console.WriteLine("Ingrese dos digitos para la HORA");
            hora12 = int.Parse(Console.ReadLine());

            if (hora12 <= 12 && hora12 > 0)
            {
                Console.WriteLine("Ingrese dos digitos para los MINUTOS");
                minutos = int.Parse(Console.ReadLine());

                if (minutos <= 59 && minutos >= 0)
                {
                    Console.WriteLine("Ingrese dos digitos para los SEGUNDOS");
                    segundos = int.Parse(Console.ReadLine());

                    if (segundos <= 59 && segundos >= 0)
                    {
                        Console.WriteLine("Determine el TURNO");
                        Console.WriteLine("(M) Si es de Mañana.");
                        Console.WriteLine("(T) Si es de Tarde.");
                        turno = Console.ReadKey().KeyChar;


                        if (Convert.ToString(turno).ToUpper() == "M")
                        {
                            Console.WriteLine($"La hora en formato Analógico es: {hora12}:{ minutos}:{segundos} AM");
                            Console.WriteLine($"La hora en formato Militar es: {hora12}:{ minutos}:{segundos} Hs");
                            Console.ReadLine();
                        }
                        else
                        {
                            if (Convert.ToString(turno).ToUpper() == "T")
                            {
                                hora24 = hora12 + 12;
                                Console.WriteLine($"La hora en formato Analógico es: {hora12}:{ minutos}:{segundos} PM");
                                Console.WriteLine($"La hora en formato Militar es: {hora24}:{ minutos}:{segundos} Hs");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("La opción ingresada es Inválida.");
                                Console.WriteLine("Fin de Programa");
                                Console.ReadLine();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Los SEGUNDOS ingresados son inválidos.");
                        Console.WriteLine("Fin de Programa");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Los MINUTOS ingresados son inválidos.");
                    Console.WriteLine("Fin de Programa");
                    Console.ReadLine();
                }

            }
            else
            {
                Console.WriteLine("La HORA ingresada no es válida.");
                Console.WriteLine("Fin de Programa");
                Console.ReadLine();
            }
        }
    }
}

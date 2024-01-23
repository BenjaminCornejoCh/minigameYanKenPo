
class Program
{

    static void Main()
    {
        int miTurno;
        int puntajeJugador = 0;
        int puntajeIA = 0;

        string piedra = "¡PIEDRA!";
        string papel = "¡PAPEL!";
        string tijera = "¡TIJERAS!";
        string empate = "¡EMPATE!";
        string ganaste = "¡GANASTE!";
        string perdiste = "¡PERDISTE!";

        Random random = new Random();
        int numeroAleatorio = 0;

        Console.WriteLine("-++----------------------------------------++-");
        Console.WriteLine(" ||        Bienvenido a Yan Ken Po         || ");
        Console.WriteLine("-++----------------------------------------++-");
        Console.WriteLine("\t¿Desea iniciar? s/n");

        switch (Console.ReadLine().ToLower())
        {
            case "s":
                Console.WriteLine("\tIniciando...\n\t");
                Console.Beep(1500,1100);

                while ( puntajeJugador < 5 && puntajeIA < 5 )
                {
                    Console.WriteLine("\tIngrese el valor según su elección:\n\t1: Piedra\n\t2: Papel\n\t3: Tijeras\n\t");
                    miTurno = int.Parse(Console.ReadLine());

                    Console.Beep(1500, 1000);
                    numeroAleatorio = random.Next(1, 4);

                    switch (miTurno)
                    {
                        case 1:
                            Console.WriteLine($"Jugador 1: \n{piedra}");
                            if (numeroAleatorio == 1)
                            {
                                Console.WriteLine($"IA: \n{piedra}\n");
                                Console.WriteLine(empate);
                            } 
                            else if (numeroAleatorio == 2) {
                                Console.WriteLine($"IA: \n{papel}\n");
                                Console.WriteLine(perdiste);
                                puntajeIA++;
                            }
                            else if (numeroAleatorio == 3)
                            {
                                Console.WriteLine($"IA: \n{tijera}\n");
                                Console.WriteLine(ganaste);
                                puntajeJugador++;
                            }
                            break;

                        case 2:
                            Console.WriteLine($"Jugador 1: \n{papel}");
                            if (numeroAleatorio == 1)
                            {
                                Console.WriteLine($"IA: \n{piedra}\n");
                                Console.WriteLine(ganaste);
                                puntajeJugador++;
                            }
                            else if (numeroAleatorio == 2)
                            {
                                Console.WriteLine($"IA: \n{papel}\n");
                                Console.WriteLine(empate);
                            }
                            else if (numeroAleatorio == 3)
                            {
                                Console.WriteLine($"IA: \n{tijera}\n");
                                Console.WriteLine(perdiste);
                                puntajeIA++;
                            }
                            break;

                        case 3:
                            Console.WriteLine($"Jugador 1: \n{tijera}");
                            if (numeroAleatorio == 1)
                            {
                                Console.WriteLine($"IA: \n{piedra}\n");
                                Console.WriteLine(perdiste);
                                puntajeIA++;
                            }
                            else if (numeroAleatorio == 2)
                            {
                                Console.WriteLine($"IA: \n{papel}\n");
                                Console.WriteLine(ganaste);
                                puntajeJugador++;
                            }
                            else if (numeroAleatorio == 3)
                            {
                                Console.WriteLine($"IA: \n{tijera}\n");
                                Console.WriteLine(empate);
                                
                            }
                            break;

                        default: 
                            Console.WriteLine("No ha ingresado un valor esperado");
                            break;
                    }
                    Console.WriteLine($"Mi Puntaje: {puntajeJugador}");
                    Console.WriteLine($"Puntaje IA: {puntajeIA}");
                }

                Console.WriteLine(puntajeJugador == 5 ? "EXCELENTE, CAMPEONASTE!!!" : "JUGASTE MUY BIEN, SUERTE PARA LA PRÓXIMA...");

                break;

            case "n":
                Console.WriteLine("\tGracias por tu participación");
                break;


        }
    }
}


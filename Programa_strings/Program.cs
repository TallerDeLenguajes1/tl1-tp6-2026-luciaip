Console.WriteLine("Ingrese una cadena de texto: ");
string? cadena_2;
string? cadena;
cadena = Console.ReadLine();
int longitud = cadena.Length;
cadena_2 = Console.ReadLine();
string? concatenada= string.Concat(cadena, cadena_2);

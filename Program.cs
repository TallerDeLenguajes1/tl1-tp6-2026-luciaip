Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);


Console.WriteLine("Ingrese un numero: ");
string ingresado = Console.ReadLine();
int numero, invertido=0;
if (int.TryParse(ingresado,out numero) && numero > 0)
{
    while (numero > 0)
    {
        invertido=invertido*10+numero%10;
        numero=numero/10;
    }
    Console.WriteLine("Valor convertido: " + invertido);
}

    string op = "1";
    int operacion;
    while(int.TryParse(op,out operacion) && operacion!=0) {
    Console.WriteLine("Ingrese un numero a: ");
    string primer = Console.ReadLine();
    Console.WriteLine("Ingrese un numero b: ");
    string segundo = Console.ReadLine();
    int numeroa, numerob, resultado=0;
    Console.WriteLine("Ingrese la operacion que quiere realizar segun el menu \n 1: suma \n 2: resta \n 3: multiplicacion \n 4: division \n 0: fin de operaciones ");
    op=Console.ReadLine();
    if (int.TryParse(primer,out numeroa) && int.TryParse(segundo, out numerob) && int.TryParse(op,out operacion))
    {
    
        switch (operacion)
            {
                case 1:
                resultado = numeroa + numerob;
                break;
                case 2: 
                    resultado = numeroa-numerob;
                break;
                case 3: 
                    resultado = numeroa * numerob;
                break;
                case 4: 
                    resultado = numeroa / numerob;
                break;
            }
            Console.WriteLine("Resultado: " + resultado);
        }
    };

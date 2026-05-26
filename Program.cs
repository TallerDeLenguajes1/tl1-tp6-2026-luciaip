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

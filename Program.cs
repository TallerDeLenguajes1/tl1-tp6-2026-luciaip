using Microsoft.VisualBasic;

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
    Console.WriteLine("Ingrese la operacion que quiere realizar segun el menu \n 1: suma \n 2: resta \n 3: multiplicacion \n 4: division \n 5: valor abs \n 6: cuadrado \n7: raiz cuad \n8: seno \n 9: cos \n 10: parte entera \n 0: fin de operaciones ");
    op=Console.ReadLine();
    while(int.TryParse(op,out operacion) && operacion!=0) {
    int numeroa, numerob, resultado=0;
    float numeroc;
    string primer="", segundo="",tercer= "";
    if(int.TryParse(op,out operacion)){

        if(operacion<=4){
        Console.WriteLine("Ingrese un numero a: ");
        primer = Console.ReadLine();
        Console.WriteLine("Ingrese un numero b: ");
        segundo = Console.ReadLine();
        if (int.TryParse(primer,out numeroa) && int.TryParse(segundo, out numerob)){
    
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
    }
    else
    {  
        Console.WriteLine("Ingrese un numero c: ");
        tercer=Console.ReadLine();
        if (float.TryParse(tercer, out numeroc))
            {
                switch (operacion)
                {
                    case 5: 
                        Console.WriteLine("Resultado=" + Math.Abs (numeroc));
                    break;
                    case 6:
                        Console.WriteLine("Resultado=" + Math.Pow (numeroc,2));
                    break;
                    case 7: 
                        Console.WriteLine("Resultado=" + Math.Sqrt (numeroc));
                    break;
                    case 8:
                        Console.WriteLine("Resultado=" + Math.Sin (numeroc));
                    break;
                    case 9:
                        Console.WriteLine("Resultado=" + Math.Cos (numeroc)); 
                    break;
                    case 10:
                        Console.WriteLine("Resultado=" + Math.Truncate(numeroc));
                    break;
                }
            }
    }
    }
    Console.WriteLine("Ingrese la operacion que quiere realizar segun el menu \n 1: suma \n 2: resta \n 3: multiplicacion \n 4: division \n 5: valor abs \n 6: cuadrado \n7: raiz cuad \n8: seno \n 9: cos \n 10: parte entera \n 0: fin de operaciones ");
    op=Console.ReadLine();
    
    }
    
    Console.WriteLine("Ingrese un numero a: ");
    string alfa = Console.ReadLine();
    int numero_a, numero_b;
    Console.WriteLine("Ingrese un numero b: ");
    string beta = Console.ReadLine();
    if (int.TryParse(alfa, out numero_a) && int.TryParse(beta, out numero_b))
    {
        if (numero_a > numero_b)
        {
           Console.WriteLine("El maximo es: " + numero_a);
           Console.WriteLine("El minimos es: " + numero_b); 
        } else {
            Console.WriteLine("El maximo es: " + numero_b);
            Console.WriteLine("El minimo es: " + numero_a);
        }
    }
    


